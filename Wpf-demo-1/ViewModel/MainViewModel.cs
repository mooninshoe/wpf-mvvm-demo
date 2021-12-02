using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using Wpf_demo_1.DB;
using Wpf_demo_1.Models;
using Wpf_demo_1.View;
using System.Linq;
using System.Windows;

namespace Wpf_demo_1.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        localDB localDb;
        public MainViewModel()
        {
            localDb = new localDB();
            QueryCommand = new RelayCommand(Query);
            ResetCommand = new RelayCommand(() =>
            {
                Search = string.Empty;
                this.Query();
            });
            EditCommand = new RelayCommand<int>(t=>Edit(t));
            DelCommand = new RelayCommand<int>(t => Del(t));
            AddCommand = new RelayCommand(Add);
        }

        private string search = string.Empty;
        public string Search
        {
            get { return search; }
            set { search = value; RaisePropertyChanged(); }
        }

        private ObservableCollection<Student> gridModelList;
        public ObservableCollection<Student> GridModelList
        {
            get { return gridModelList; }
            set { gridModelList = value; RaisePropertyChanged(); }
        }

        #region Command
        public RelayCommand QueryCommand { get; set; }
        public RelayCommand ResetCommand { get; set; }
        public RelayCommand<int> EditCommand { get; set; }
        public RelayCommand<int> DelCommand { get; set; }
        public RelayCommand AddCommand { get; set; }
        #endregion

        public void Query()
        {
            var models = localDb.GetStudentsByName(Search);
            GridModelList = new ObservableCollection<Student>();
            if (models != null)
            {
                foreach (Student student in models)
                {
                    GridModelList.Add(student);
                }
            }
        }

        public void Edit(int id) {
            var model = localDb.GetStudentById(id);
            if (model != null) {
                var view = new UserView(model);
                var r =  view.ShowDialog();
                if (r.Value)
                {
                   var newModel = GridModelList.FirstOrDefault(x => x.Id == model.Id);
                    if (newModel!=null)
                    {
                            newModel.Name = model.Name;
                    }
                }
            }
        }

        public void Add()
        {
            var stu = new Student();
            UserView view = new UserView(stu);
            var r = view.ShowDialog();
            if (r.Value) {
                stu.Id = GridModelList.Max(x => x.Id) + 1;
                localDb.AddStudent(stu);
                this.Query();
            }
            
        }

        public void Del(int id) {
            var model = localDb.GetStudentById(id);
            if (model!=null)
            {
                var r = MessageBox.Show($"确认删除当前用于:{model.Name}？", "操作提示", MessageBoxButton.OK, MessageBoxImage.Question);
                if (r == MessageBoxResult.OK) { 
                    localDb.DelStudent(id);
                    this.Query();
                }
            }
        }

    }
}