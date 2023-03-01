using System;
namespace Pontaap.Studio
{
    public class EventManager  
    {
        /// <summary>
        /// Ateşleme tuşuna basıldığında tetiklenecek fonksiyon.
        /// </summary>
        public static Action AFire;
        /// <summary>
        /// Score her güncellendiğinde bu fonksiyon tetiklecektir.
        /// </summary>
        public static Action AScore;
    }
}
