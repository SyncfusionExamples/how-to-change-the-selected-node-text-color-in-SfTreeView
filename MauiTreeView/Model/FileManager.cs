﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiTreeView
{
    public class FileManager : INotifyPropertyChanged
    {
        #region Fields

        private string fileName;
        private ImageSource imageIcon;
        private ObservableCollection<FileManager> subFiles;
        private Color labelColor = Colors.Black;

        #endregion

        #region Constructor
        public FileManager()
        {
        }

        #endregion

        #region Properties
        public ObservableCollection<FileManager> SubFiles
        {
            get { return subFiles; }
            set
            {
                subFiles = value;
                RaisedOnPropertyChanged("SubFiles");
            }
        }
        public Color LabelColor
        {
            get { return labelColor; }
            set
            {
                labelColor = value;
                RaisedOnPropertyChanged("LabelColor");
            }
        }

        public string ItemName
        {
            get { return fileName; }
            set
            {
                fileName = value;
                RaisedOnPropertyChanged("ItemName");
            }
        }
        public ImageSource ImageIcon
        {
            get { return imageIcon; }
            set
            {
                imageIcon = value;
                RaisedOnPropertyChanged("ImageIcon");
            }
        }

        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

        #endregion
    }
}
