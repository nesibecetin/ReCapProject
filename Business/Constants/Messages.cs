using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded ="Araba eklendi.";
        public static string CarInvalid = "Geçersiz araba fiyatı";
        public static string CarListed = "Arabalar Listelendi.";
        public static string BrandListed = "Markalar Listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandInvalid = "Geçersiz Marka Özelliği";
        public static string CarUpdated="";
        public static string CarDeleted="";
        public static string ColorAdded="";
        public static string ColorDeleted="";
        public static string ColorListed="";
        public static string ColorUpdated="";
        internal static string CustomerAdded;
        internal static string CustomerListed;
        internal static string RentalAdded;
        internal static string RentalDeleted;
        internal static string RentalListed;
        internal static string RentalUpdated;
        internal static string RentalInvalid;
        internal static object ImagesAdded;

        internal static string CarImageLimit = "5'den fazla resim ekleyemezsiniz.";
        public static string AuthorizationDenied="Giriş yapılamadı.";
        internal static string UserRegistered="Kullanıcı Kaydedildi.";
        internal static string UserNotFound="c";
        internal static string PasswordError="d";
        internal static string SuccessfulLogin="e";
        public static string UserAlreadyExists = "b";
        internal static string AddedUser="a";
        internal static string AccessTokenCreated="f";
    }
}
