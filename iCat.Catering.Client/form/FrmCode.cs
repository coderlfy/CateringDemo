using Foundation.Core;
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
        private List<TypeCodeOfType> _codeTypes = null;
        private CateringService.TypeCodeClient _typecodeService = null;

        public FrmCode()
        {
            #region
            InitializeComponent();

            //初始化码值服务接口的服务对象
            if (_typecodeService == null)
                _typecodeService = new CateringService.TypeCodeClient();

            //初始化界面中的码值父类型控件
            this.initTypeCodeOfType();
            #endregion
        }

        private void btnSave_Click(
            object sender, EventArgs e)
        {

        }

        private void initTypeCodeOfType()
        {
            #region
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

            //给码值父类型添加选择事件
            this.lbTypeCode.SelectedIndexChanged += lbTypeCode_SelectedIndexChanged;

            //首次进入本页面需要激活
            //第一个默认选择的码值类型列表显示相应的所有码值
            lbTypeCode_SelectedIndexChanged(null, null);
            #endregion
        }

        private void lbTypeCode_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            #region
            //调用服务端的码值列表
            //拿到的是json格式的字符串
            string json = _typecodeService.GetTypeCodes(
                new CateringService.EntityTypeCode(){ 
                    PType = lbTypeCode.SelectedValue.ToString()
                });

            //将字符串反序列化成对象（此处的对象为表格中显示的数据集）
            TypeCodeData typecodeds = JsonConvert.DeserializeObject<TypeCodeData>(
                json, JsonHelperV2._JsonSettingIgnoreNULL);


            //将数据集绑定到控件上
            this.dgvTypeList.DataSource = typecodeds.Tables[0].DefaultView;
            #endregion
        }

        private void FrmCode_Load(
            object sender, EventArgs e)
        {
        }
    }
}
