#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : MM_StockOut
//   Form Name    : 원자재 생산 출고 등록
//   Name Space   : KDT_Form
//   Created Date : 2023-01-16
//   Made By      : KHS
//   Description  : 최초 프로그램 작성

//   Edit Date :
//   Made By   :
//   Description :
// *---------------------------------------------------------------------------------------------*
#endregion
using DC00_assm;
using Infragistics.Win;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace KDT_Form
{
    public partial class MM_StockOut : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
        public MM_StockOut()
        {
            InitializeComponent();
        }
        #endregion

        #region < EVENT AREA >
        private void MM_StockOut_Load(object sender, EventArgs e)
        {

			    // 1. 그리드 셋팅.
			    #region < Grid>
			    GridUtil.InitializeGrid(this.grid1); // 그리드 초기화. 
                GridUtil.InitColumnUltraGrid(grid1, "CHK",               "선택",         GridColDataType_emu.CheckBox,        70, HAlign.Center,  true,  true);                                                                                                                                     
                GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",         "공장",         GridColDataType_emu.VarChar,        120, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "INDATE",            "입고일자",     GridColDataType_emu.VarChar,        140, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",          "품목",         GridColDataType_emu.VarChar,        140, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",          "품목명",       GridColDataType_emu.VarChar,        140, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "MATLOTNO",          "LOTNO",        GridColDataType_emu.VarChar,        120, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "STOCKQTY",          "재고수량",     GridColDataType_emu.Double,         120, HAlign.Right,   true, false);
                GridUtil.InitColumnUltraGrid(grid1, "UNITCODE",          "단위",         GridColDataType_emu.VarChar,         80, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "MAKER",             "입고자",       GridColDataType_emu.VarChar,        100, HAlign.Left,    true, false);        
                GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",          "등록일시",     GridColDataType_emu.DateTime24,     150, HAlign.Left,    true, false);

                GridUtil.SetInitUltraGridBind(grid1); // 그리드 데이터 바인딩 초기화.
			    #endregion

			    // 2. 콤보박스 셋팅.
			    DataTable dtTemp = new DataTable(); // 콤보박스 셋팅 할 데이터를 받아올 자료형.

                // 공장
                dtTemp = Common.StandardCODE("PLANTCODE");                     // 공통기준정보 PLANTCODE 데이터 가져오기.
                Common.FillComboboxMaster(cboPlantCode, dtTemp);               // 콤보박스 컨트롤에 셋팅.
                UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);   // 그리드에 콤보박스 셋팅.

                // 단위
                dtTemp = Common.StandardCODE("UNITCODE");
                UltraGridUtil.SetComboUltraGrid(grid1, "UNITCODE", dtTemp);


                // 품목
                // ROH : 원자재, HALB : 반제품, FERT : 완제품
                dtTemp = Common.Get_ItemCode(new string[] { "ROH" });
                Common.FillComboboxMaster(cboItemCode, dtTemp);
                UltraGridUtil.SetComboUltraGrid(grid1, "ITEMCODE", dtTemp); 
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
                string sPIantCode     = Convert.ToString(this.cboPlantCode.Value);      
				string sItemCode      = Convert.ToString(this.cboItemCode.Value);       
				string sLOTNO         = Convert.ToString(txtLOTNO.Text);                            
                string sStartDate     = string.Format("{0:yyyy-MM-dd}", dtpStartDate.Value);    
                string sEndDate       = string.Format("{0:yyyy-MM-dd}", dtpEndDate.Value);

				DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02MM_StockOut_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE",       sPIantCode)
                                          , helper.CreateParameter("@MATLOTNO" ,       sLOTNO)
                                          , helper.CreateParameter("@ITEMCODE" ,       sItemCode)
                                          , helper.CreateParameter("@STARTDATE",       sStartDate)
                                          , helper.CreateParameter("@ENDDATE  ",       sEndDate)


									);
                if (dtTemp.Rows.Count == 0)
                {
                    ShowDialog("조회할 내역이 없습니다.");
                    // 그리드 내역 초기화
                    GridUtil.Grid_Clear(grid1);
                    return;
                }
                grid1.DataSource = dtTemp;
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


		public override void DoSave()
		{
			// 데이터 변경 내역 확인
            // 체크박스 체크 된 내역 확인.
            DataTable dtTemp = new DataTable();
            dtTemp = grid1.chkChange(); 
           
            DBHelper helper= new DBHelper(true);
            try
            {
                string sChkStatus = string.Empty;
                for (int i = 0; i < dtTemp.Rows.Count; i++) 
                {
                    // 체크 상태 확인.
                    sChkStatus = Convert.ToString(dtTemp.Rows[i]["CHK"]);
                    if (sChkStatus != "1")
                    {
                        // 출고 등록 대상으로 체크를 하지 않았다면 continue;
                        continue;
                    }

                    // 원자재 출고 등록 로직 구현.
                    helper.ExecuteNoneQuery("MM_StockOut_U1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE", Convert.ToString(dtTemp.Rows[i]["PLANTCODE"]))
                                          , helper.CreateParameter("@ITEMCODE",  Convert.ToString(dtTemp.Rows[i]["ITEMCODE"]))
                                          , helper.CreateParameter("@LOTNO",     Convert.ToString(dtTemp.Rows[i]["MATLOTNO"]))
                                          , helper.CreateParameter("@QTY",       Convert.ToString(dtTemp.Rows[i]["STOCKQTY"]))           
                                          , helper.CreateParameter("@UNITCODE",  Convert.ToString(dtTemp.Rows[i]["UNITCODE"]))
										  , helper.CreateParameter("@WORKERID",  LoginInfo.UserID) // 원자재 출고 등록자
                                          );

                    if (helper.RSCODE != "S")
                    {
                        throw new Exception($"출고 등록 중 오류가 발생하였습니다.\r\n{helper.RSMSG}");
                    }
				}
				helper.Commit();
                ShowDialog("정상적으로 출고 등록을 완료 하였습니다.");
                
			}
            catch(Exception ex)
            {
                helper.Rollback();
                ShowDialog(ex.ToString());
            }
            finally
            {
                helper.Close();
            }
		}


		#endregion
	}
}
