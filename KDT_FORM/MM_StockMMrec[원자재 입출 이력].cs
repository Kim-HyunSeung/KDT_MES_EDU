#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : MM_StockMMrec
//   Form Name    : 자재 재고 현황
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
    public partial class MM_StockMMrec : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
        public MM_StockMMrec()
        {
            InitializeComponent();
        }
        #endregion

        #region < EVENT AREA >
        private void MM_StockMMrec_Load(object sender, EventArgs e)
        {
                   
                // 1. 그리드 셋팅.

                GridUtil.InitializeGrid(grid1); // 그리드 초기화. 
                GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",         "공장",         GridColDataType_emu.VarChar,     100, HAlign.Left,    true, true);
                GridUtil.InitColumnUltraGrid(grid1, "MATLOTNO",          "LOTNO",        GridColDataType_emu.VarChar,      80, HAlign.Center,  true, true);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",          "품목",         GridColDataType_emu.VarChar,     150, HAlign.Left,    true, true);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",          "품목명",       GridColDataType_emu.VarChar,     150, HAlign.Left,    true, true);
                GridUtil.InitColumnUltraGrid(grid1, "INOUTDATE",         "입출일자",     GridColDataType_emu.VarChar,      80, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "WHCODE",            "창고",     GridColDataType_emu.VarChar,          80, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "INOUTCODE",         "입출유형",     GridColDataType_emu.VarChar,      80, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "INOUTFLAG",         "입출구분",     GridColDataType_emu.VarChar,     150, HAlign.Left,    true, true);
                GridUtil.InitColumnUltraGrid(grid1, "INOUTQTY",          "입출수량",     GridColDataType_emu.VarChar,      80, HAlign.Center,  true, true);
                GridUtil.InitColumnUltraGrid(grid1, "BASEUNIT",          "단위",         GridColDataType_emu.VarChar,      80, HAlign.Right,   true, true);
                GridUtil.InitColumnUltraGrid(grid1, "INOUTWORKER",       "입출등록자",   GridColDataType_emu.VarChar,     130, HAlign.Center,  true, false);
                GridUtil.InitColumnUltraGrid(grid1, "PONO",              "발주번호",     GridColDataType_emu.VarChar,     100, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "MAKER",             "등록자",       GridColDataType_emu.VarChar,     100, HAlign.Left,    true, false);        
                GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",          "등록일시",     GridColDataType_emu.DateTime24 , 150, HAlign.Left,    true, false);

                GridUtil.SetInitUltraGridBind(grid1); // 그리드 데이터 바인딩 초기화.


                // 2. 콤보박스 셋팅.
                DataTable dtTemp = new DataTable(); // 콤보박스 셋팅 할 데이터를 받아올 자료형.

                // 공장
                dtTemp = Common.StandardCODE("PLANTCODE");                    // 공통기준정보 PLANTCODE 데이터 가져오기.
                Common.FillComboboxMaster(cboPlantCode, dtTemp);   // 콤보박스 컨트롤에 셋팅.
                UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);  // 그리드에 콤보박스 셋팅.

                // 그리드 창고
                dtTemp = Common.StandardCODE("WHCODE");
                UltraGridUtil.SetComboUltraGrid(grid1, "WHCODE", dtTemp);
               
                // 그리드 입출 유형
                dtTemp = Common.StandardCODE("INOUTCODE");
                UltraGridUtil.SetComboUltraGrid(grid1, "INOUTCODE", dtTemp);

                // 그리드 입출 구분
                dtTemp = Common.StandardCODE("INOUTFLAG");
                UltraGridUtil.SetComboUltraGrid(grid1, "INOUTFLAG", dtTemp);
               
                // 그리드 단위
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
                string sLOTNO        = txtLOTNO.Text;                              // 발주 번호
                string sItemCode    = Convert.ToString(cboItemCode.Value);       // 품목
                string sPOStartDate = string.Format("{0:yyyy-MM-dd}", dtpStart.Value); // 발주 시작일자
                string sPOEndDate   = string.Format("{0:yyyy-MM-dd}", dtpEnd.Value);   // 발주 종료일자


                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02MM_StockMMrec_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE",      sPIantCode)
                                          , helper.CreateParameter("@MATLOTNO",       sLOTNO)
                                          , helper.CreateParameter("@ITEMCODE",       sItemCode)
                                          , helper.CreateParameter("@STARTDATE",      sPOStartDate)
                                          , helper.CreateParameter("@ENDDATE",      sPOEndDate)



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







        #endregion


    }
}
