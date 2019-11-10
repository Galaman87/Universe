using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Universe.Infrastructure;

namespace Universe.ElementNames
{
    public class BattonNames:NotifyChanged
    {

        private string _language;
        
        private string _create;
        private string _rename;
        private string _update;
        private string _delete;
        private string _save;
        private string _filters;



        public string Language
        {
            get => _language;
            set
            {
                this._language = value;
                Notify();
            }
        }
        public string Create
        {
            get => _create;
            set
            {
                this._create = value;
                Notify();
            }
        }
        public string Rename
        {
            get => _rename;
            set
            {
                this._rename = value;
                Notify();
            }
        }
        public string Update
        {
            get => _update;
            set
            {
                this._update = value;
                Notify();
            }
        }
        public string Delete
        {
            get => _delete;
            set
            {
                this._delete = value;
                Notify();
            }
        }
        public string Save
        {
            get => _save;
            set
            {
                this._save = value;
                Notify();
            }
        }
        public string Filters
        {
            get => _filters;
            set
            {
                this._filters = value;
                Notify();
            }
        }

        public BattonNames()
        {
            Init();           
        }

        private void Init()
        {           
            Create = "Create";
            Rename = "Rename";
            Update = "Update";
            Delete = "Delete";
            Save = "Save";
            Language = "En";
            Filters = "Filters";

        }

        public void ChangeLanguageEn()
        {
            Init();
        }
        
        public void ChangeLanguageUa()
        {
            Create = "Створити";
            Rename = "Перейменувати";
            Update = "Обновити";
            Delete = "Видалити";
            Save = "Зберегти";
            Language = "Ua";
            Filters = "Фильтри";
        }
        
        public void ChangeLanguageRu()
        {
            Create = "Создaть";
            Rename = "Переименовать";
            Update = "Обновить";
            Delete = "Удалить";
            Save = "Сохранить";
            Language = "Ru";
            Filters = "Фильтры";
        }

    }
}
