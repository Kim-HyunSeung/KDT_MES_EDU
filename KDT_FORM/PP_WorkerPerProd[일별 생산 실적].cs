#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : PP_WorkerPerProd
//   Form Name    : 일별 생산 실적 현황
//   Name Space   : KDT_Form
//   Created Date : 2023-01-04
//   Made By      : KHS
//   Description  : 최초 프로그램 생성

//   Edit Date :
//   Made By   :
//   Description :
// *---------------------------------------------------------------------------------------------*
#endregion
using DC00_assm;
using DC00_PuMan;
using Infragistics.Win;
using Infragistics.Win.UltraWinGrid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KDT_Form
{
    public partial class PP_WorkerPerProd : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
        public PP_WorkerPerProd()
        {
            InitializeComponent();
        }
        #endregion

        #region < EVENT AREA >
        private void PP_WorkerPerProd_Load(object sender, EventArgs e)
        {
                  
                // 1. 그리드 셋팅.

                GridUtil.InitializeGrid(grid1); // 그리드 초기화. 
                GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",         "공장",         GridColDataType_emu.VarChar,     100, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "WORKER",            "작업자",       GridColDataType_emu.VarChar,      80, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "PRODDATE",          "생산일자",     GridColDataType_emu.VarChar,  150, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERCODE",    "작업장",       GridColDataType_emu.VarChar,     150, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERNAME",    "작업장명",     GridColDataType_emu.VarChar,      80, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",          "품목",         GridColDataType_emu.VarChar,     120, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",          "품명",         GridColDataType_emu.VarChar,      80, HAlign.Left, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "PRODQTY",           "생산수량",     GridColDataType_emu.Double,      150, HAlign.Right, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "BADQTY",            "불량수량",     GridColDataType_emu.Double,       80, HAlign.Right, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "TOTALPROD",         "총생산량",     GridColDataType_emu.Double,       80, HAlign.Right, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "BADPROD",           "불량률",       GridColDataType_emu.VarChar,     130, HAlign.Right, true, false);
                GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",          "생산일시",     GridColDataType_emu.DateTime24,  150, HAlign.Left,  true, false);
                GridUtil.SetInitUltraGridBind(grid1); 

                // 하위 행의 정보가 같을 경우 머지(merge,병합) 한다.
                grid1.DisplayLayout.Override.MergedCellContentArea = MergedCellContentArea.VisibleRect;
                grid1.DisplayLayout.Bands[0].Columns["PLANTCODE"].MergedCellStyle      = MergedCellStyle.Always;
                grid1.DisplayLayout.Bands[0].Columns["WORKER"].MergedCellStyle         = MergedCellStyle.Always;
                grid1.DisplayLayout.Bands[0].Columns["PRODDATE"].MergedCellStyle       = MergedCellStyle.Always;
                grid1.DisplayLayout.Bands[0].Columns["WORKCENTERCODE"].MergedCellStyle = MergedCellStyle.Always;
                grid1.DisplayLayout.Bands[0].Columns["WORKCENTERNAME"].MergedCellStyle = MergedCellStyle.Always;
                grid1.DisplayLayout.Bands[0].Columns["ITEMCODE"].MergedCellStyle       = MergedCellStyle.Always;
                grid1.DisplayLayout.Bands[0].Columns["ITEMNAME"].MergedCellStyle       = MergedCellStyle.Always;


			// 2. 콤보박스 셋팅.
			DataTable dtTemp = new DataTable(); // 콤보박스 셋팅 할 데이터를 받아올 자료형.

                // 공장
                dtTemp = Common.StandardCODE("PLANTCODE");                    
                Common.FillComboboxMaster(cboPlantCode, dtTemp);   
                UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);  

			    //작업자 팝업 호출
			    BizTextBoxManager btbManager = new BizTextBoxManager();
			    btbManager.PopUpAdd(txtWorkerId, txtWorkerName, "WORKER_MASTER");



		}
        #endregion

        #region < TOOLBAR AREA >
        public override void DoInquire()
        {
            base.DoInquire();

            DBHelper helper = new DBHelper(false);
            try
            {
                // 조회 조건 변수 등록 및 데이터 대입
                string sPIantCode   = Convert.ToString(cboPlantCode.Value);                                                            
                string sPOStartDate = string.Format("{0:yyyy-MM-dd}", dtpStartDate.Value); 
                string sPOEndDate   = string.Format("{0:yyyy-MM-dd}", dtpEndDate.Value);   
                string sWorkerId    = Convert.ToString(txtWorkerId.Value);


                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02PP_WorkerPerProd_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE",      sPIantCode)                                                                              
                                          , helper.CreateParameter("@STARTDATE",      sPOStartDate)
                                          , helper.CreateParameter("@ENDDATE",        sPOEndDate)
                                          , helper.CreateParameter("@WORKERID",       sWorkerId)

									);


				if (dtTemp.Rows.Count == 0)
				{
					ShowDialog("조회할 내역이 없습니다.");
					// 그리드 내역 초기화.
					GridUtil.Grid_Clear(grid1);
					return;
				}

				if (dtTemp.Rows.Count != 0)
                {
					#region < SUB-TOTAL LOGIC >
                    DataTable dtSubTable = dtTemp.Clone(); // 데이터 테이블 서식 복사.

                    string sWorkerID = Convert.ToString(dtTemp.Rows[0]["WORKER"]);
                    double dProdQty  = Convert.ToDouble(dtTemp.Rows[0]["PRODQTY"]);
                    double dBadQty   = Convert.ToDouble(dtTemp.Rows[0]["BADQTY"]);
                    double dTotalQty = Convert.ToDouble(dtTemp.Rows[0]["TOTALPROD"]);

                    dtSubTable.Rows.Add(new object[]
                    {
                        Convert.ToString(dtTemp.Rows[0]["PLANTCODE"]),
                        Convert.ToString(dtTemp.Rows[0]["WORKER"]),
                        Convert.ToString(dtTemp.Rows[0]["PRODDATE"]),
                        Convert.ToString(dtTemp.Rows[0]["WORKCENTERCODE"]),
                        Convert.ToString(dtTemp.Rows[0]["WORKCENTERNAME"]),
                        Convert.ToString(dtTemp.Rows[0]["ITEMCODE"]),
                        Convert.ToString(dtTemp.Rows[0]["ITEMNAME"]),
                        Convert.ToString(dtTemp.Rows[0]["PRODQTY"]),
                        Convert.ToString(dtTemp.Rows[0]["BADQTY"]),
                        Convert.ToString(dtTemp.Rows[0]["TOTALPROD"]), // 총생산량
                        Convert.ToString(dtTemp.Rows[0]["BADPROD"]),   // 불량률
                        Convert.ToString(dtTemp.Rows[0]["MAKEDATE"]),
					});
                   
                    for (int i = 1; i<dtTemp.Rows.Count; i++)
                    {
                        if (sWorkerID == Convert.ToString(dtTemp.Rows[i]["WORKER"]))
                        {

                            dProdQty  += Convert.ToDouble(dtTemp.Rows[i]["PRODQTY"]);
                            dBadQty   += Convert.ToDouble(dtTemp.Rows[i]["BADQTY"]);
                            dTotalQty += Convert.ToDouble(dtTemp.Rows[i]["TOTALPROD"]);

                            dtSubTable.Rows.Add(new object[]
                                    {
                                        Convert.ToString(dtTemp.Rows[i]["PLANTCODE"]),
                                        Convert.ToString(dtTemp.Rows[i]["WORKER"]),
                                        Convert.ToString(dtTemp.Rows[i]["PRODDATE"]),
                                        Convert.ToString(dtTemp.Rows[i]["WORKCENTERCODE"]),
                                        Convert.ToString(dtTemp.Rows[i]["WORKCENTERNAME"]),
                                        Convert.ToString(dtTemp.Rows[i]["ITEMCODE"]),
                                        Convert.ToString(dtTemp.Rows[i]["ITEMNAME"]),
                                        Convert.ToString(dtTemp.Rows[i]["PRODQTY"]),
                                        Convert.ToString(dtTemp.Rows[i]["BADQTY"]),
                                        Convert.ToString(dtTemp.Rows[i]["TOTALPROD"]), // 총생산량
                                        Convert.ToString(dtTemp.Rows[i]["BADPROD"]),   // 불량률
                                        Convert.ToString(dtTemp.Rows[i]["MAKEDATE"]),
                                    });
                        }
                        else
                        {
                            dtSubTable.Rows.Add(new object[] {"", "", "", "", "", "", "합 계 :", dProdQty, dBadQty, dTotalQty,
                                                              Convert.ToString(Math.Round((dBadQty * 100) / dTotalQty, 1)) + "%",null});

                            sWorkerID = Convert.ToString(dtTemp.Rows[i]["WORKER"]);
							dProdQty  = Convert.ToDouble(dtTemp.Rows[i]["PRODQTY"]);
							dBadQty   = Convert.ToDouble(dtTemp.Rows[i]["BADQTY"]);
							dTotalQty = Convert.ToDouble(dtTemp.Rows[i]["TOTALPROD"]);

							dtSubTable.Rows.Add(new object[]
									{
										Convert.ToString(dtTemp.Rows[i]["PLANTCODE"]),
										Convert.ToString(dtTemp.Rows[i]["WORKER"]),
										Convert.ToString(dtTemp.Rows[i]["PRODDATE"]),
										Convert.ToString(dtTemp.Rows[i]["WORKCENTERCODE"]),
										Convert.ToString(dtTemp.Rows[i]["WORKCENTERNAME"]),
										Convert.ToString(dtTemp.Rows[i]["ITEMCODE"]),
										Convert.ToString(dtTemp.Rows[i]["ITEMNAME"]),
										Convert.ToString(dtTemp.Rows[i]["PRODQTY"]),
										Convert.ToString(dtTemp.Rows[i]["BADQTY"]),
										Convert.ToString(dtTemp.Rows[i]["TOTALPROD"]), // 총생산량
                                        Convert.ToString(dtTemp.Rows[i]["BADPROD"]),   // 불량률
                                        Convert.ToString(dtTemp.Rows[i]["MAKEDATE"]),
									});
						}
                    }
					dtSubTable.Rows.Add(new object[] {"", "", "", "", "", "", "합 계 :", dProdQty, dBadQty, dTotalQty,
															  Convert.ToString(Math.Round((dBadQty * 100) / dTotalQty, 1)) + "%",null});

                    grid1.DataSource= dtSubTable;
					#endregion
				}
				
				
			}
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
        }

		#endregion

		private void grid1_InitializeLayout(object sender, InitializeLayoutEventArgs e)
		{
            CustomMergedCellEvalutor CM1 = new CustomMergedCellEvalutor("WORKER", "WORKCENTERCODE");
            e.Layout.Bands[0].Columns["WORKCENTERNAME"].MergedCellEvaluator = CM1;
            e.Layout.Bands[0].Columns["ITEMCODE"].MergedCellEvaluator       = CM1;
            e.Layout.Bands[0].Columns["ITEMNAME"].MergedCellEvaluator       = CM1;

			CustomMergedCellEvalutor CM2 = new CustomMergedCellEvalutor("WORKCENTERCODE", "PRODDATE");
			e.Layout.Bands[0].Columns["PRODDATE"].MergedCellEvaluator       = CM2;

		}

		private void grid1_InitializeRow(object sender, InitializeRowEventArgs e)
		{
            if (Convert.ToString( e.Row.Cells["PLANTCODE"].Value) == "")
            {
                e.Row.Appearance.BackColor = Color.Aqua;
            }
		}
	}
}
