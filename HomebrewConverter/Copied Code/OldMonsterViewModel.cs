//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HomebrewConverter.Copied_Code
//{
//    class OldMonsterViewModel
//    {
//    }

//    #region Construction
//    public MonsterViewModel()
//    {
//    Monster = new Monster();
//    }
//    #endregion

//    #region Properties
//    public Monster Monster { get; set; }

//    #endregion

//    public string Title
//    {
//    get => Monster.Title;
//    set
//    {
//        if (Monster.Title != value)
//        {
//            Monster.Title = value;
//        }
//    }
//    }

//    public event PropertyChangedEventHandler PropertyChanged;

//    [NotifyPropertyChangedInvocator]
//    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
//    {
//    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
//    }
//}
