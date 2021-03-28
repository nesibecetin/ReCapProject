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
        public static string CustomerAdded="";
        public static string CustomerListed="";
        public static string RentalAdded="";
        public static string RentalDeleted="";
        public static string RentalListed="";
        public static string RentalUpdated="";
        public static string RentalInvalid="Araç Önce Teslim Edilmeli.";
        public static string ImagesAdded="";

        public static string CarImageLimit = "5'den fazla resim ekleyemezsiniz.";
        public static string AuthorizationDenied="Giriş yapılamadı.";
        public static string UserRegistered="Kullanıcı Kaydedildi.";
        public static string UserNotFound="c";
        public static string PasswordError="d";
        public static string SuccessfulLogin="e";
        public static string UserAlreadyExists = "b";
        public static string AddedUser="a";
        public static string AccessTokenCreated="f";
        public static string RentalCar="";
    }
}
