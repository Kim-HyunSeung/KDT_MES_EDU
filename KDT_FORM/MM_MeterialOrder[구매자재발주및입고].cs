#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : MM_MeterialOrder
//   Form Name    : 구매자제 발주 및 입고
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
    public partial class MM_MeterialOrder : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
        public MM_MeterialOrder()
        {
            InitializeComponent();
        }
        #endregion

        #region < EVENT AREA >
        private void MM_MeterialOrder_Load(object sender, EventArgs e)
        {
                   
                // 1. 그리드 셋팅.

                GridUtil.InitializeGrid(grid1); // 그리드 초기화. 
                GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",         "공장",         GridColDataType_emu.VarChar,    100, HAlign.Left,    true,  true);
                                                                         
                // 구매 자재 발주.                                      
                GridUtil.InitColumnUltraGrid(grid1, "PONO",              "발주번호",     GridColDataType_emu.VarChar,        130, HAlign.Center,  true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",          "발주품목",     GridColDataType_emu.VarChar,        150, HAlign.Left,    true,  true);
                GridUtil.InitColumnUltraGrid(grid1, "PODATE",            "발주일자",     GridColDataType_emu.YearMonthDay,   150, HAlign.Left,    true,  true);
                GridUtil.InitColumnUltraGrid(grid1, "POQTY",             "발주수량",     GridColDataType_emu.Double,          80,  HAlign.Right,  true,  true);
                GridUtil.InitColumnUltraGrid(grid1, "UNITCODE",          "단위",         GridColDataType_emu.VarChar,         80,  HAlign.Left,   true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "CUSTCODE",          "거래처",       GridColDataType_emu.VarChar,        150, HAlign.Left,    true,  true);

                // 구매자재 입고.
                GridUtil.InitColumnUltraGrid(grid1, "CHK",               "입고",         GridColDataType_emu.CheckBox,    80, HAlign.Center,   true, true);
                GridUtil.InitColumnUltraGrid(grid1, "INQTY",             "입고수량",     GridColDataType_emu.Double,      80, HAlign.Left,     true, true);
                GridUtil.InitColumnUltraGrid(grid1, "LOTNO",             "LOT번호",      GridColDataType_emu.VarChar,    130, HAlign.Center,  true, false);
                GridUtil.InitColumnUltraGrid(grid1, "INDATE",            "입고일자",     GridColDataType_emu.VarChar,    100, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "INWORKER",          "입고자",       GridColDataType_emu.VarChar,    100, HAlign.Left,    true, false);
   
             
                GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",          "등록일시",     GridColDataType_emu.DateTime24, 150, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "MAKER",             "등록자",       GridColDataType_emu.VarChar,    100, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "EDITDATE",          "수정일시",     GridColDataType_emu.DateTime24, 150, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "EDITOR",            "수정자",       GridColDataType_emu.VarChar,    100, HAlign.Left,    true, false);
                GridUtil.SetInitUltraGridBind(grid1); // 그리드 데이터 바인딩 초기화.


                // 2. 콤보박스 셋팅.
                DataTable dtTemp = new DataTable(); // 콤보박스 셋팅 할 데이터를 받아올 자료형.

                // 공장
                dtTemp = Common.StandardCODE("PLANTCODE");                    // 공통기준정보 PLANTCODE 데이터 가져오기.
                Common.FillComboboxMaster(cboPlantCode, dtTemp);   // 콤보박스 컨트롤에 셋팅.
                UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);  // 그리드에 콤보박스 셋팅.

                // 거래처
                dtTemp = Common.GET_Cust_Code();
                Common.FillComboboxMaster(cboCustCode, dtTemp);
                UltraGridUtil.SetComboUltraGrid(grid1, "CUSTCODE", dtTemp);

                     
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
                string sPIantCode   = Convert.ToString(cboPlantCode.Value);      // 공장
                string sCustCode    = Convert.ToString(cboCustCode.Value);       // 거래처
                string sPoNO        = txtPoNO.Text;                              // 발주 번호
                string sItemCode    = Convert.ToString(cboItemCode.Value);       // 품목
                string sPOStartDate = string.Format("{0:yyyy-MM-dd}", dtpStart.Value); // 발주 시작일자
                string sPOEndDate   = string.Format("{0:yyyy-MM-dd}", dtpEnd.Value);   // 발주 종료일자

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02MM_MeterialOrder_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE",      sPIantCode)
                                          , helper.CreateParameter("@CUSTCODE",       sCustCode)
                                          , helper.CreateParameter("@PONO",           sPoNO)
                                          , helper.CreateParameter("@ITEMCODE",       sItemCode)
                                          , helper.CreateParameter("@STARTDATE",      sPOStartDate)
                                          , helper.CreateParameter("@ENDDATE",        sPOEndDate)

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

        public override void DoNew()
        {
            // 신규행 추가.
            grid1.InsertRow();

            // 기본값 셋팅.
            grid1.SetDefaultValue("PLANTCODE", LoginInfo.PlantCode);
            grid1.SetDefaultValue("CHK", 0);     // 확정체크
            grid1.SetDefaultValue("PODATE", string.Format("{0:yyyy-MM-dd}",DateTime.Now)); // 오늘일자

        }

        public override void DoDelete()
        {
            grid1.DeleteRow();
        }

        public override void DoSave()
        {
            base.DoSave();
            // 저장 할 대상이 있는지 확인 (그리드에 변경된 내역이 있는지 추출)
            // 밸리데이션 체크.
            DataTable dtTemp = grid1.chkChange();
            if (dtTemp == null)
            {
                ShowDialog("저장 할 내역이 없습니다.");
                return;
            }

            string sMessage = string.Empty; // 필수 입력 내역 확인 용 변수.
            // 저장 로직.
            DBHelper helper = new DBHelper(true); // 트랜잭션 사용 DB 커넥터.
            try
            {
                foreach (DataRow dr in dtTemp.Rows)
                {

                    switch (dr.RowState)
                    {

                        case DataRowState.Deleted:
                            dr.RejectChanges(); // 삭제된 데이터 원상 복귀.

                            // 생산계획 을 취소
                            helper.ExecuteNoneQuery("02MM_MeterialOrder_D1", CommandType.StoredProcedure,
                                                    helper.CreateParameter("@PLANTCODE", Convert.ToString(dr["PLANTCODE"])),
                                                    helper.CreateParameter("@PLANNO", Convert.ToString(dr["PLANNO"]))
                                                   );
                            break;
                        case DataRowState.Added:

                            // 구매자재 발주 등록
                            if (Convert.ToString(dr["ITEMCODE"]) == "") sMessage = "발주품목 ";
                            if (Convert.ToString(dr["CUSTCODE"]) == "") sMessage = "거래처 ";
                            if (Convert.ToString(dr["PODATE"]) == "")   sMessage += "발주일자 ";
                            if (Convert.ToString(dr["POQTY"]) == "")    sMessage += "발주수량 ";

                            if (sMessage != "")  throw new Exception(sMessage + " 를/을 입력하지 않았습니다. ");
                            
                            helper.ExecuteNoneQuery("02MM_MeterialOrder_I1", CommandType.StoredProcedure,
                                                    helper.CreateParameter("@PLANTCODE", Convert.ToString(dr["PLANTCODE"])),
                                                    helper.CreateParameter("@ITEMCODE",  Convert.ToString(dr["ITEMCODE"])),
                                                    helper.CreateParameter("@POQTY",     Convert.ToString(dr["POQTY"])),
                                                    helper.CreateParameter("@UNITCODE",  Convert.ToString(dr["UNITCODE"])),
                                                    helper.CreateParameter("@CUSTCODE",  Convert.ToString(dr["CUSTCODE"])),
                                                    helper.CreateParameter("@PODATE",    Convert.ToString(dr["PODATE"])),
                                                    helper.CreateParameter("@MAKER",     LoginInfo.UserID)
                                                   );

                            break;
                        case DataRowState.Modified:

                            // 발주 내역으로 입고 등록.
                            if (Convert.ToString(dr["INQTY"]) =="") throw new Exception("입고 수량을 입력하지 않았습니다.");


                            helper.ExecuteNoneQuery("02MM_MeterialOrder_U1", CommandType.StoredProcedure,
                                                    helper.CreateParameter("@PLANTCODE",   Convert.ToString(dr["PLANTCODE"])),
                                                    helper.CreateParameter("@PONO",        Convert.ToString(dr["PONO"])),
                                                    helper.CreateParameter("@INQTY",       Convert.ToString(dr["INQTY"])),
                                                    helper.CreateParameter("@ITEMCODE",    Convert.ToString(dr["ITEMCODE"])),
                                                    helper.CreateParameter("@EDITOR",      LoginInfo.UserID)
                                                   );
                            break;
                    }
                    if (helper.RSCODE != "S") throw new Exception(helper.RSMSG); 
                    // 2 번째 방법
                    // helper.Rollback(); ShowDialog(helper.RSMSG); return;

                }
                helper.Commit();
                ShowDialog("정상적으로 등록을 완료 하였습니다.");
                DoInquire(); // 재조회
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
    }
}
