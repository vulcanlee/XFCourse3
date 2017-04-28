using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace XFDataBinding.ViewModels
{
    public class INPCPageViewModel : INotifyPropertyChanged
    {
        #region Repositories (遠端或本地資料存取)

        #endregion

        #region ViewModel Property (用於在 View 中作為綁定之用)

        #region 基本型別與類別的 Property
        private string _MyEntry;

        public string MyEntry
        {
            get { return _MyEntry; }
            set
            {
                if (_MyEntry != value)
                {
                    _MyEntry = value;
                    OnPropertyChanged("MyEntry");
                }
            }
        }

        private string _MyLabel;

        public string MyLabel
        {
            get { return _MyLabel; }
            set {
                if (_MyLabel != value)
                {
                    _MyLabel = value;
                    OnPropertyChanged("MyLabel");
                }
            }
        }

        public ICommand 登入Command { get; set; }
        #endregion

        #region 集合類別的 Property

        #endregion

        #endregion

        #region Field 欄位

        #region ViewModel 內使用到的欄位
        public event PropertyChangedEventHandler PropertyChanged;
        #endregion

        #region 命令物件欄位
        #endregion

        #region 注入物件欄位
        #endregion

        #endregion

        #region Constructor 建構式
        public INPCPageViewModel()
        {

            #region 頁面中綁定的命令
            登入Command = new Command(() =>
            {
                MyLabel = MyEntry;
            });
            #endregion
        }

        #endregion

        #region 設計時期或者執行時期的ViewModel初始化
        #endregion

        #region 相關事件
        #endregion

        #region 相關的Command定義
        #endregion

        #region 其他方法

        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                // 若 PropertyChanged 有被綁定，則將會執行這個事件，
                // 以進行頁面控制項的內容更新
                PropertyChanged(this,
                    new PropertyChangedEventArgs(propertyName));
            }
        }
        #endregion
    }
    }
