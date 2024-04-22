﻿using Newtonsoft.Json;
using System.ComponentModel;

namespace Shared_Static_Class.Models
{
    public class UsersAtivos : INotifyPropertyChanged
    {
        private List<AcessoModel> usuariosAtivos { get; set; } = new();

        public List<AcessoModel> UsuariosAtivos
        {
            get => usuariosAtivos;
            set
            {
                usuariosAtivos = value;

                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(UsuariosAtivos)));
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;
    }

}
