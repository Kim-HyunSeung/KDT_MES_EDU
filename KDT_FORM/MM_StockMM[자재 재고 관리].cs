#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : MM_StockMM
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
using DC_POPUP;
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
    public partial class MM_StockMM : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
        public MM_StockMM()
        {
            InitializeComponent();
        }
        #endregion

        #region < EVENT AREA >
        private void MM_StockMM_Load(object sender, EventArgs e)
        {
                   
                // 1. 그리드 셋팅.

                GridUtil.InitializeGrid(grid1); // 그리드 초기화. 
                GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE",         "공장",         GridColDataType_emu.VarChar,        100, HAlign.Left,    true,  true);                                                                                                                                     
                GridUtil.InitColumnUltraGrid(grid1, "ITEMCODE",          "품목",         GridColDataType_emu.VarChar,        150, HAlign.Left,    true,  true);
                GridUtil.InitColumnUltraGrid(grid1, "ITEMNAME",          "품목명",       GridColDataType_emu.VarChar,   150, HAlign.Left,    true,  true);
                GridUtil.InitColumnUltraGrid(grid1, "MATLOTNO",          "LOT번호",      GridColDataType_emu.VarChar,          80,  HAlign.Right,  true,  true);
                GridUtil.InitColumnUltraGrid(grid1, "WHCODE",            "창고",         GridColDataType_emu.VarChar,         80,  HAlign.Left,   true,  false);
                GridUtil.InitColumnUltraGrid(grid1, "STOCKQTY",          "재고수량",     GridColDataType_emu.VarChar,        150, HAlign.Left,    true,  true);

                GridUtil.InitColumnUltraGrid(grid1, "UNITCODE",          "단위",         GridColDataType_emu.CheckBox,    80, HAlign.Center,   true, true);
                GridUtil.InitColumnUltraGrid(grid1, "CUSTCODE",          "거래처",       GridColDataType_emu.VarChar,      80, HAlign.Left,     true, true);
                GridUtil.InitColumnUltraGrid(grid1, "CUSTNAME",          "거래처명",     GridColDataType_emu.VarChar,    130, HAlign.Center,  true, false);
                GridUtil.InitColumnUltraGrid(grid1, "INDATE",            "입고일자",     GridColDataType_emu.VarChar,    100, HAlign.Left,    true, false);
                GridUtil.InitColumnUltraGrid(grid1, "MAKER",             "생성자",       GridColDataType_emu.VarChar,    100, HAlign.Left,    true, false);        
                GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE",          "생성일시",     GridColDataType_emu.DateTime24, 150, HAlign.Left,    true, false);

                GridUtil.SetInitUltraGridBind(grid1); // 그리드 데이터 바인딩 초기화.


                // 2. 콤보박스 셋팅.
                DataTable dtTemp = new DataTable(); // 콤보박스 셋팅 할 데이터를 받아올 자료형.

                // 공장
                dtTemp = Common.StandardCODE("PLANTCODE");                    // 공통기준정보 PLANTCODE 데이터 가져오기.
                Common.FillComboboxMaster(cboPlantCode, dtTemp);   // 콤보박스 컨트롤에 셋팅.
                UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);  // 그리드에 콤보박스 셋팅.

                // 단위
                dtTemp = Common.StandardCODE("UNITCODE");
                UltraGridUtil.SetComboUltraGrid(grid1, "UNITCODE", dtTemp);

                //whcode
                dtTemp = Common.StandardCODE("WHCODE");
                UltraGridUtil.SetComboUltraGrid(this.grid1, "WHCODE", dtTemp);

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

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02MM_StockMM_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("@PLANTCODE",      sPIantCode)
                                          , helper.CreateParameter("@MATLOTNO",       sLOTNO)
                                          , helper.CreateParameter("@ITEMCODE",       sItemCode)


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

		private void btnLOTMake_Click(object sender, EventArgs e)
		{
            // 원자재 식별표 발행
            if (grid1.ActiveRow == null) return;

            //바코드 디자이너에 던져줄 원자재 품목 데이터 변수 설정.
            DataRow drRow = ((DataTable)grid1.DataSource).NewRow();
            drRow["MATLOTNO"] = Convert.ToString(grid1.ActiveRow.Cells["MATLOTNO"].Value);
            drRow["ITEMCODE"] = Convert.ToString(grid1.ActiveRow.Cells["ITEMCODE"].Value);
            drRow["ITEMNAME"] = Convert.ToString(grid1.ActiveRow.Cells["ITEMNAME"].Value);
            drRow["STOCKQTY"] = Convert.ToString(grid1.ActiveRow.Cells["STOCKQTY"].Value);
            drRow["UNITCODE"] = Convert.ToString(grid1.ActiveRow.Cells["UNITCODE"].Value);


            // 바코드 디자이너에 출력할 식별표 데이터 매핑

            // 바코드 디자이너 객체 생성.
            Report_LotBacodeROH ROH_BARCODE         = new Report_LotBacodeROH();

            // 레포트 북 객체 생성.
            Telerik.Reporting.ReportBook reportBook = new Telerik.Reporting.ReportBook();

            // 바코드 디자인 객체에 데이터 매핑
            ROH_BARCODE.DataSource = drRow;

            // 디자인을 레포트 북에 등록.
            reportBook.Reports.Add(ROH_BARCODE);

            // 바코드 디자이너 뷰어(미리보기) 에 레포트 북 등록 및 표현.
            ReportViewer Viewer = new ReportViewer(reportBook,1);
			Viewer.ShowDialog();
		}
	}
}
