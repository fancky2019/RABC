using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RABC.UserControls
{
    public partial class PageNavigator : UserControl
    {
        private int _pageIndex = 1;
        private int _total;
        private event Action<int, int> _pageIndexChanged;
        [Description("页索引改变事件")]
        public event Action<int, int> PageIndexChanged
        {
            add { _pageIndexChanged += value; }
            remove { _pageIndexChanged -= value; }
        }
        //private event Action<int, int> _pageSizeChanged;
        //[Description("页大小改变事件")]
        //public event Action<int, int> PageSizeChanged
        //{
        //    add { _pageSizeChanged += value; }
        //    remove { _pageSizeChanged -= value; }
        //}
        /// <summary>
        /// 总条数
        /// </summary>
        [Description("总条数")]
        public int Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
                SetEnable();
                int n = Total % Take;
                int totalPages = n == 0 ? Total / _take : (Total / _take)+1;
                this.lblInfo.Text = $"共{_total}条记录，共{totalPages}页";
            }
        }
        private int _take = 10;
        /// <summary>
        /// 每页显示条数
        /// </summary>
        [Description("每页显示条数")]
        public int Take
        {
            get
            {
                return _take;
            }
        }
        private int _skip = 0;
        /// <summary>
        /// 跳过条数
        /// </summary>
        [Description("跳过条数")]
        public int Skip
        {
            get
            {
                return _skip;
            }
            set
            {
                this._skip = value;
                this._pageIndex = (_skip / this._take) + 1;
                this.tePageIndex.Text = _pageIndex.ToString();
            }
        }

        public PageNavigator()
        {
            InitializeComponent();
            this.cmbCount.SelectedItem = "50";
            SetEnable();
        }
        private void SetEnable()
        {
            this.sbtnFirst.Enabled = true;
            this.sbtnUp.Enabled = true;
            this.sbtnNext.Enabled = true;
            this.sbtnLast.Enabled = true;
            if (_skip == 0)
            {
                this.sbtnFirst.Enabled = false;
                this.sbtnUp.Enabled = false;
            }
            if (_skip + _take >= _total)
            {
                this.sbtnNext.Enabled = false;
                this.sbtnLast.Enabled = false;
            }
        }

        /// <summary>
        /// 首页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnFirst_Click(object sender, EventArgs e)
        {
            this._skip = 0;
            this._pageIndex = 1;
            this.tePageIndex.Text = _pageIndex.ToString();
            _pageIndexChanged(this._take,this._skip);
        }

        /// <summary>
        /// 上一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnUp_Click(object sender, EventArgs e)
        {
            this._skip -= this._take;
            this._skip = this._skip < 0 ? 0 : this._skip;
            this._pageIndex -= 1;
            this.tePageIndex.Text = _pageIndex.ToString();
            _pageIndexChanged?.Invoke(this._take, this._skip);
        }

        /// <summary>
        /// 下一页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnNext_Click(object sender, EventArgs e)
        {
            this._skip += this._take;
            this._skip = this._skip >= Total ? Total : this._skip;
            this._pageIndex += 1;
            this.tePageIndex.Text = _pageIndex.ToString();
            _pageIndexChanged?.Invoke(this._take, this._skip);
        }

        /// <summary>
        /// 尾页
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sbtnLast_Click(object sender, EventArgs e)
        {
            int n = Total % Take;
            _skip = n == 0 ? Total - _take : Total - n;
            this._pageIndex = n == 0 ? Total / _take : (Total / _take) + 1;
            this.tePageIndex.Text = _pageIndex.ToString();
            _pageIndexChanged?.Invoke(this._take, this._skip);
        }

        private void cmbCount_SelectedIndexChanged(object sender, EventArgs e)
        {
            this._take = int.Parse(this.cmbCount.SelectedItem.ToString());
            this._skip = 0;
            this._pageIndex = 1;
            this.tePageIndex.Text = _pageIndex.ToString();
            _pageIndexChanged?.Invoke(this._take, this._skip);
        }
    }
}
