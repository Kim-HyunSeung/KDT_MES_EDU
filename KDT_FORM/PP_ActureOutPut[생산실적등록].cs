#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : PP_ActureOutPut
//   Form Name    : 자재 재고 현황
//   Name Space   : KDT_Form
//   Created Date : 2023-01-017
//   Made By      : KHS
//   Description  : 최초 프로그램 생성

//   Edit Date :
//   Made By   :
//   Description :
// *---------------------------------------------------------------------------------------------*
#endregion
using DC_POPUP;
using DC00_assm;
using DC00_PuMan;
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
    public partial class PP_ActureOutPut : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
        public PP_ActureOutPut()
        {
            InitializeComponent();
        }
        #endregion

        #region < EVENT AREA >
        private void PP_ActureOutPut_Load(object sender, EventArgs e)
        {
                   
                // 1. 그리드 셋팅.

                GridUtil.InitializeGrid(grid1);  
                GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",         "공장",          GridColDataType_emu.VarChar,    100, HAlign.Left,  false, false);                                                                                                                                     
                GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERCODE",    "작업장",        GridColDataType_emu.VarChar,    100, HAlign.Left,  false, false);
                GridUtil.InitColumnUltraGrid(grid1, "WORKCENTERNAME",    "작업장명",      GridColDataType_emu.VarChar,    150, HAlign.Left,  true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "ORDERNO",           "작업지시",      GridColDataType_emu.VarChar,    200, HAlign.Left,  true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",          "생산품목",      GridColDataType_emu.VarChar,    200, HAlign.Left,  true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",          "생산품명",      GridColDataType_emu.VarChar,    200, HAlign.Left,  true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "ORDERQTY",          "지시수량",      GridColDataType_emu.Double,     120, HAlign.Right, true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "PRODQTY",           "양품수량",      GridColDataType_emu.Double,     120, HAlign.Right, true,  false);
			    GridUtil.InitColumnUltraGrid(grid1, "BADQTY",            "불량수량",      GridColDataType_emu.Double,     120, HAlign.Right, true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "UNITCODE",          "단위",          GridColDataType_emu.VarChar,    100, HAlign.Left,  true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "WORKSTATUSCODE",    "R/S코드",       GridColDataType_emu.VarChar,    100, HAlign.Left,  false, false);
                GridUtil.InitColumnUltraGrid(grid1, "WORKSTATUS",        "상태",          GridColDataType_emu.VarChar,    100, HAlign.Left,  true,  false);                                                                                                                                                  
                GridUtil.InitColumnUltraGrid(grid1, "MATLOTNO",          "투입LOT",       GridColDataType_emu.VarChar,    300, HAlign.Left,  true,  false);
		     	GridUtil.InitColumnUltraGrid(grid1, "COMPONENTQTY",      "투입잔량",      GridColDataType_emu.Double,     120, HAlign.Right, true,  false);
		     	GridUtil.InitColumnUltraGrid(grid1, "WORKER",            "작업자코드",    GridColDataType_emu.VarChar,    100, HAlign.Left,  false, false);
		     	GridUtil.InitColumnUltraGrid(grid1, "WORKERNAME",        "작업자",        GridColDataType_emu.VarChar,    100, HAlign.Left,  true,  false);
		     	GridUtil.InitColumnUltraGrid(grid1, "ORDSTARTDATE",      "지시시작일시",  GridColDataType_emu.DateTime24, 400, HAlign.Left,  true,  false);

                GridUtil.SetInitUltraGridBind(grid1); 


                // 2. 콤보박스 셋팅.
                DataTable dtTemp = new DataTable(); 

                // 공장
                dtTemp = Common.StandardCODE("PLANTCODE");                    
                Common.FillComboboxMaster(cboPlantCode, dtTemp);   
                UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);  

                // 단위
                dtTemp = Common.StandardCODE("UNITCODE");
                UltraGridUtil.SetComboUltraGrid(grid1, "UNITCODE", dtTemp);

                //작업장
                dtTemp = Common.GET_Workcenter_Code();
                Common.FillComboboxMaster(cboWorkcenter, dtTemp);

                //작업자 팝업 호출
                BizTextBoxManager btbManager = new BizTextBoxManager();
                btbManager.PopUpAdd(txtWorkerID, txtWorkerName, "WORKER_MASTER");
        }
        #endregion

        #region < TOOLBAR AREA >
        public override void DoInquire()
        {
           

            DBHelper helper = new DBHelper(false);
            try
            {

				string sPlantCode = Convert.ToString(cboPlantCode.Value); // 공장
				string sWorkcenterCode = Convert.ToString(cboWorkcenter.Value);  // 품목     

				DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02PP_ActureOutPut_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE", sPlantCode)
                                          , helper.CreateParameter("@WORKCENTERCODE", sWorkcenterCode)
                                    );
                if (dtTemp.Rows.Count == 0)
                {
                    ShowDialog("조회할 내역이 없습니다.");
                  
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

		

		private void cboWorkcenter_ValueChanged(object sender, EventArgs e)
		{
            DoInquire();
		}
        #endregion

		#region < 2. 작업자 등록 >
		private void btnWorkerReg_Click(object sender, EventArgs e)
		{
            // 작업장을 선택 하였는지 확인.
            if (grid1.ActiveRow == null) return;

            // 조회된 작업장이 없을경우 리턴.
            if (grid1.Rows.Count == 0) return;

            // 등록 할 작업자를 조회 하였는지 확인.
            string sWorkerId = txtWorkerID.Text;

			if (sWorkerId == "")
            {
                ShowDialog("작업자를 선택 후 진행 하세요.");
                return;
            }

			DBHelper helper = new DBHelper(true);
			try 
            {
				string sPIantCode      = Convert.ToString(grid1.ActiveRow.Cells["PLANTCODE"].Value);
				string sWorkcenterCode = Convert.ToString(grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);
				DataTable dtTemp       = new DataTable();
                helper.ExecuteNoneQuery("02PP_ActureOutPut_I1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE", sPIantCode)
                                          , helper.CreateParameter("@WORKCENTERCODE", sWorkcenterCode)
                                          , helper.CreateParameter("@WORKERID", sWorkerId));


                if (helper.RSCODE != "S") throw new Exception(helper.RSMSG);
	            helper.Commit();
                ShowDialog("작업자 등록을 완료 하였습니다.");
                DoInquire();
            }
            catch (Exception ex)
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

		private void grid1_AfterRowActivate(object sender, EventArgs e)
		{
            txtWorkerID.Text   = Convert.ToString(grid1.ActiveRow.Cells["WORKER"].Value);
            txtWorkerName.Text = Convert.ToString(grid1.ActiveRow.Cells["WORKERNAME"].Value);
		}


		#region < 3. 작업지시 선택 >
		private void btnOrderNo_Click(object sender, EventArgs e)
		{
            // 작업장을 선택하지 않았거나 작업지시 등록 대상 작업장이 그리드에 조회 되지
            // 않았을 경우 return;
            if (grid1.ActiveRow == null) return;

            if (grid1.Rows.Count == 0) return;

            // 1. 작업다 등록 여부 확인.
            string sWorkerId = Convert.ToString(grid1.ActiveRow.Cells["WORKER"].Value);
            if (sWorkerId == "")
            {
                ShowDialog("작업자 를 선택 후 진행 하세요.");
                return;
            }


			// if (Convert.Tostring(grid1.ActiveRow.Cells["WORKSTATUSCODE"].Value) == "R")
			// ShowDialog(" 현재 작업장이 가동중이므로 비가동 후 진행하세요.");
            // return;
			string sWorkSCode = Convert.ToString(grid1.ActiveRow.Cells["WORKSTATUSCODE"].Value);
            if (sWorkSCode == "R")
            {
				ShowDialog(" 현재 작업장이 가동중이므로 비가동 후 진행하세요.");
				return;
			}

			string sLotNo = Convert.ToString(grid1.ActiveRow.Cells["MATLOTNO"].Value);
			if (sLotNo != "")
			{
				ShowDialog("작업장에 투입된 원자재 LOT 의 정보가 존재 합니다.\r\n 투입을 취소 후 진행하세요.");
				return;
			}

			// 작업지시를 선택 할 작업장 정보 변수에 담기.
			string sWorkcenterCode = Convert.ToString(grid1.ActiveRow.Cells["WORKCENTERCODE"].Value);
			string sWorkcenterName = Convert.ToString(grid1.ActiveRow.Cells["WORKCENTERNAME"].Value);

			string sPlantCode = Convert.ToString(grid1.ActiveRow.Cells["PLANTCODE"].Value);


			POP_ORDERNO OrderPopup = new POP_ORDERNO(sWorkcenterCode, sWorkcenterName);
			OrderPopup.ShowDialog();

			string dOrderNo = Convert.ToString(OrderPopup.Tag);
			if (dOrderNo == "") return;

			// 선택한 작업지시 등록 로직 구현.

			DBHelper helper = new DBHelper();
			try
			{
				helper.ExecuteNoneQuery("02PP_ActureOutPut_I2", CommandType.StoredProcedure
						  , helper.CreateParameter("@PLANTCODE", sPlantCode)
						  , helper.CreateParameter("@ORDERNO", dOrderNo)
						  , helper.CreateParameter("@WORKCENTERCODE", sWorkcenterCode)
						  , helper.CreateParameter("@WORKERID", sWorkerId)
					);
				if (helper.RSCODE != "S") throw new Exception(helper.RSMSG);
				helper.Commit();
				ShowDialog("작업지시 등록을 완료 하였습니다");
				DoInquire();
			}
			catch (Exception ex)
			{
				helper.Rollback();
				MessageBox.Show(ex.ToString());
			}
			finally
			{
				helper.Close();
			}
		}
		#endregion
	}
}
