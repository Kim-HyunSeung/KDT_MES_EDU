#region < HEADER AREA >
// *---------------------------------------------------------------------------------------------*
//   Form ID      : BM_WorkCenterMaster[작업자마스터]
//   Form Name    : 비가동 항목 관리
//   Name Space   : KDT_Form
//   Created Date : 2023-01-02
//   Made By      : KHS
//   Description  : 기준정보(작업장마스터) 관리 화면

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
    public partial class BM_StopListMaster : DC00_WinForm.BaseMDIChildForm
    {
        #region < MEMBER AREA >
        public BM_StopListMaster()
        {
            InitializeComponent();
        }
        #endregion
     
        #region < EVENT AREA >
        private void BM_StopListMaster_Load(object sender, EventArgs e)
        {
            // 1. 그리드 셋팅.
            UltraGridUtil GridUtil = new UltraGridUtil(); // 그리드를 셋팅하는 클래스.
            GridUtil.InitializeGrid(grid1); // 그리드 초기화. 
            GridUtil.InitColumnUltraGrid(grid1, "PLANTCODE", "공장", GridColDataType_emu.VarChar, 100, HAlign.Left, true, false);
            GridUtil.InitColumnUltraGrid(grid1, "STOPCODE", "비가동코드", GridColDataType_emu.VarChar, 100, HAlign.Left, true, false);
            GridUtil.InitColumnUltraGrid(grid1, "STOPNAME", "비가동 명", GridColDataType_emu.VarChar, 130, HAlign.Left, true, true);
            GridUtil.InitColumnUltraGrid(grid1, "REMARK", "비고", GridColDataType_emu.VarChar, 100, HAlign.Left, true, true);
            GridUtil.InitColumnUltraGrid(grid1, "USEFLAG", "사용여부", GridColDataType_emu.VarChar, 100, HAlign.Left, true, true);

            GridUtil.InitColumnUltraGrid(grid1, "MAKER", "등록자", GridColDataType_emu.VarChar, 100, HAlign.Left, true, false);
            GridUtil.InitColumnUltraGrid(grid1, "MAKEDATE", "등록일시", GridColDataType_emu.DateTime24, 150, HAlign.Left, true, false);
            GridUtil.InitColumnUltraGrid(grid1, "EDITOR", "수정자", GridColDataType_emu.VarChar, 100, HAlign.Left, true, false);
            GridUtil.InitColumnUltraGrid(grid1, "EDITDATE", "수정일시", GridColDataType_emu.DateTime24, 150, HAlign.Left, true, false);
            GridUtil.SetInitUltraGridBind(grid1); // 그리드 데이터 바인딩 초기화.

            // 2. 콤보박스 셋팅.
            Common _common = new Common(); // Common 클래스 객체 생성.
            DataTable dtTemp = new DataTable(); // 콤보박스 셋팅 할 데이터를 받아올 자료형.

            // 공장
            dtTemp = _common.Standard_CODE("PLANTCODE");                  // 공통기준정보 PLANTCODE 데이터 가져오기.
            Common.FillComboboxMaster(cboPlantCode, dtTemp);   // 콤보박스 컨트롤에 셋팅.
            UltraGridUtil.SetComboUltraGrid(grid1, "PLANTCODE", dtTemp);  // 그리드에 콤보박스 셋팅.

            // 사용여부
            dtTemp = _common.Standard_CODE("USEFLAG");                  // 공통기준정보 PLANTCODE 데이터 가져오기.
            Common.FillComboboxMaster(cboUseFlagCode, dtTemp);   // 콤보박스 컨트롤에 셋팅.
            UltraGridUtil.SetComboUltraGrid(grid1, "USEFLAG", dtTemp);  // 그리드에 콤보박스 셋팅.
        }
            #endregion
        
        #region < TOOLBAR AREA >
        public override void DoNew()
        {
            // 신규행 추가.
            grid1.InsertRow();

            // 기본값 셋팅.
            grid1.SetDefaultValue("PLANTCODE", LoginInfo.PlantCode);
            grid1.SetDefaultValue("USEFLAG", "Y");  // 사용여부
        }

        public override void DoDelete()
        {
            grid1.DeleteRow();
        }

        public override void DoInquire()
        {
            base.DoInquire();

            // 트랜잭션을 사용하지 않을 helper
            DBHelper helper = new DBHelper(false);
            try
            {
                // 조회 조건 변수 등록 및 데이터 대입
                string sPIantCode = Convert.ToString(cboPlantCode.Value);   // 공장
                string STOPCODE = txtStopCode.Text;                         // 비가동 코드
                string STOPNAME = txtStopName.Text;                         // 비가동 명
                string sUseFlag = Convert.ToString(cboUseFlagCode.Value);   // 사용여부

                DataTable dtTemp = new DataTable();
                dtTemp = helper.FillTable("02BM_StopListMaster_S1", CommandType.StoredProcedure
                                          , helper.CreateParameter("PLANTCODE", sPIantCode)
                                          , helper.CreateParameter("STOPCODE", STOPCODE)
                                          , helper.CreateParameter("STOPNAME", STOPNAME)
                                          , helper.CreateParameter("USEFLAG", sUseFlag)
                                    );
                grid1.DataSource = dtTemp;
                if (dtTemp.Rows.Count == 0)
                {
                    ShowDialog("조회할 내역이 없습니다.");
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
            base.DoSave();

            DataTable dt = grid1.chkChange();
            if (dt == null)
                return;
            DBHelper helper = new DBHelper(true);

            try
            {

                foreach (DataRow drRow in dt.Rows)
                {
                    switch (drRow.RowState)
                    {
                        case DataRowState.Deleted:
                            #region 삭제
                            drRow.RejectChanges();

                            helper.ExecuteNoneQuery("02BM_StopListMaster_D1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("@PLANTCODE", Convert.ToString(drRow["PLANTCODE"]))
                                                    , helper.CreateParameter("@STOPCODE",  Convert.ToString(drRow["STOPCODE"])));
                            #endregion
                            break;
                        case DataRowState.Added:
                            #region 추가                       

                            helper.ExecuteNoneQuery("02BM_StopListMaster_I1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("@PLANTCODE", Convert.ToString(drRow["PLANTCODE"]))
                                                    , helper.CreateParameter("@STOPCODE",  Convert.ToString(drRow["STOPCODE"]))
                                                    , helper.CreateParameter("@STOPNAME",  Convert.ToString(drRow["STOPNAME"]))
                                                    , helper.CreateParameter("@REMARK",    Convert.ToString(drRow["REMARK"]))
                                                    , helper.CreateParameter("@USEFLAG ",  Convert.ToString(drRow["USEFLAG"]))
                                                    , helper.CreateParameter("@MAKER",     LoginInfo.UserID)

                                                    );
                            #endregion
                            break;
                        case DataRowState.Modified:
                            #region 수정

                            helper.ExecuteNoneQuery("02BM_StopListMaster_U1"
                                                    , CommandType.StoredProcedure
                                                    , helper.CreateParameter("@PLANTCODE", Convert.ToString(drRow["PLANTCODE"]))
                                                    , helper.CreateParameter("@STOPCODE",  Convert.ToString(drRow["STOPCODE"]))
                                                    , helper.CreateParameter("@STOPNAME",  Convert.ToString(drRow["STOPNAME"]))
                                                    , helper.CreateParameter("@REMARK",    Convert.ToString(drRow["REMARK"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("@USEFLAG",   Convert.ToString(drRow["USEFLAG"]), DbType.String, ParameterDirection.Input)
                                                    , helper.CreateParameter("@EDITOR",    LoginInfo.UserID)
                                                    

                                                    );
                            #endregion
                            break;
                    }
                    if (helper.RSCODE != "S")
                    {
                        throw new Exception($"등록 중 오류가 발생하였습니다.\r\n{helper.RSMSG}");
                    }
                }

                ClosePrgForm();
                helper.Commit();
                ShowDialog("정상적으로 등록 하였습니다.");
                DoInquire();


            }
            catch (Exception ex)
            {
                ClosePrgForm();
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
    

