using OpenApiEditor.OpenApi;
using OpenApiEditor.ViewModels.Main;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace OpenApiEditor
{
    /// <summary>
    /// Base pour le modèle
    /// </summary>
    public class ViewModelBase<KeyType> : INotifyPropertyChanged
        //where KeyType : IComparable
    {
        private KeyType _id;

        /// <summary>
        /// Nom du schéma
        /// </summary>
        public KeyType ID
        {
            get => _id;
            set
            {
                if (!AreValuesEqual(_id, value))
                {
                    _id = value;
                    RaisePropertyChanged();
                }
            }
        }

        /// <summary>
        /// Event quand la propriété change
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Permet de lancer l'event PropertyChanged pour une propriété
        /// </summary>
        protected virtual void RaisePropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Load les données
        /// </summary>
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public virtual async Task LoadAsync()
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        {   

        }

        /// <summary>
        /// Permet de déterminer si 2 valeurs sont identiques
        /// </summary>
        private bool AreValuesEqual<T>(T valueA, T valueB)
        {
            if (valueA == null && valueB != null)
                return false;
            if (valueA != null && valueB == null)
                return false;
            return valueA.Equals(valueB);
        }

    }
}
