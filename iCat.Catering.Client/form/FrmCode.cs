using iCat.Catering.Client.entity;
using iCat.Catering.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace iCat.Catering.Client.form
{
    public partial class FrmCode : Form
    {
        private JsonSerializerSettings _jSetting = null;
        public FrmCode()
        {
            InitializeComponent();

            if (this._jSetting == null)
            {
                this._jSetting = new JsonSerializerSettings();
                this._jSetting.NullValueHandling = NullValueHandling.Ignore;
            }

            if (_typecodeService == null)
                _typecodeService = new CateringService.TypeCodeClient();

            this.initTypeCodeOfType();
        }

        private void btnSave_Click(
            object sender, EventArgs e)
        {

        }

        private List<TypeCodeOfType> _codeTypes = null;
        private CateringService.TypeCodeClient _typecodeService = null;
        private void initTypeCodeOfType()
        {
            //初始化数据
            if (_codeTypes == null)
            {
                _codeTypes = new List<TypeCodeOfType>();
                _codeTypes.Add(new TypeCodeOfType { PType = "1001", Name = "食物形态" });
                _codeTypes.Add(new TypeCodeOfType { PType = "1002", Name = "菜系" });
            }
            //将数据绑定到控件
            this.lbTypeCode.DataSource = _codeTypes;
            this.lbTypeCode.DisplayMember = "Name";
            this.lbTypeCode.ValueMember = "PType";

            this.lbTypeCode.SelectedIndexChanged += lbTypeCode_SelectedIndexChanged;

            lbTypeCode_SelectedIndexChanged(null, null);
        }

        private void lbTypeCode_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            string json = _typecodeService.GetTypeCodes(
                new CateringService.EntityTypeCode(){ 
                    PType = lbTypeCode.SelectedValue.ToString()
                });

            TypeCodeData typecodeds = JsonConvert.DeserializeObject<TypeCodeData>(
                json, this._jSetting);

            this.dgvTypeList.DataSource = typecodeds.Tables[0].DefaultView;
        }

        private void FrmCode_Load(
            object sender, EventArgs e)
        {
        }
    }
}
