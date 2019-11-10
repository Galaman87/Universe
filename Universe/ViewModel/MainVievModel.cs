using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Universe.BLL.Model;
using Universe.BLL.Services;
using Universe.DAL.Repositories;
using Universe.ElementNames;
using Universe.Infrastructure;
using Universe.Extensions;

namespace Universe.ViewModel
{
    public class MainVievModel : NotifyChanged
    {
        private BattonNames _battonNames;
        public BattonNames BattonNames
        {
            get => _battonNames;
            set
            {
                this._battonNames = value;
                Notify();
            }
        }

        public HeavenlyBodyDTO SelectedBody { get; set; }

        IService<HeavenlyBodyDTO> bodyService;
        public ObservableCollection<HeavenlyBodyDTO> Bodys { get; set; }

        public MainVievModel(IService<HeavenlyBodyDTO> bodyService)
        {
            this.bodyService = bodyService;
            Configure();
        }

        public MainVievModel()
        {
            bodyService = new HeavenlyBodyDTOService(new HeavenlyBodyRepository());
            Configure();
        }



        private void Configure()
        {
            _battonNames = new BattonNames();

            ChangeLanguageRu = new RelayCommand(x =>
            {
                _battonNames.ChangeLanguageRu();
                Notify();
            });
            ChangeLanguageUa = new RelayCommand(x =>
            {
                _battonNames.ChangeLanguageUa();
                Notify();
            });
            ChangeLanguageEn = new RelayCommand(x =>
            {
                _battonNames.ChangeLanguageEn();
                Notify();
            });


            Bodys = (bodyService.GetAll()).ToObservableCollection();

            RemoveCommand = new RelayCommand(x =>
            {
                bodyService.Delete(SelectedBody);
                Bodys.Remove(SelectedBody);
            }, x => Bodys.Count > 0);
            AddCommand = new RelayCommand(x =>
            {
                HeavenlyBodyDTO newCar = new HeavenlyBodyDTO();
                bodyService.Create(newCar);
                Bodys.Add(newCar);
            });
            SaveCommand = new RelayCommand(x =>
            {
                bodyService.Update(SelectedBody);
            });
            /*foreach (var item in bodyService.GetAll())
            {
                MessageBox.Show(item.Name);
            }*/
        }


        public ICommand RemoveCommand { get; set; }
        public ICommand AddCommand { get; set; }
        public ICommand SaveCommand { get; set; }
        public ICommand ChangeLanguageEn { get; set; }
        public ICommand ChangeLanguageRu { get; set; }
        public ICommand ChangeLanguageUa { get; set; }



    }
}
