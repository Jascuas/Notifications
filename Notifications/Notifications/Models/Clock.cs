﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;
using Plugin.LocalNotifications;
namespace Notifications.Models
{
    public class Clock : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisedPropertyChanged(String propiedad)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propiedad));
            }
        }

        private int _Hora;
        public Clock(int hora)
        {
            this.Hora = hora;
                Device.StartTimer(TimeSpan.FromSeconds(1), () =>
                {
                    this.Hora--;
                    if (Hora == 0)
                    {
                        CrossLocalNotifications.Current.Show("Notificaciones", "Has llegado a 0 de " + hora);
                        return false;
                    }
                    else 
                    return true;
                });

            
        }

        public int Hora
        {
            get { return this._Hora; }
            set { this._Hora = value; RaisedPropertyChanged("Hora"); }
        }
    }
}