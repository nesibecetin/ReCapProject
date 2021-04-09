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
        public static string CarUpdated = "Araç Güncellendi.";
        public static string CarDeleted = "Araç Silindi.";

        public static string BrandListed = "Markalar Listelendi.";
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandInvalid = "Geçersiz Marka Özelliği";
       
        public static string ColorAdded= "Renk eklendi.";
        public static string ColorDeleted="Renk Silindi";
        public static string ColorListed="Renkler Listelendi";
        public static string ColorUpdated="Renk Güncellendi";

        public static string CustomerAdded="Eklendi";
        public static string CustomerListed="Müşteriler Listelendi.";

        public static string RentalAdded="Kiralama Başarılı";
        public static string RentalDeleted= "Kiralama Silindi";
        public static string RentalListed= "Kiralamalar Lİstelendi";
        public static string RentalUpdated= "Kiralama Güncellendi.";
        public static string RentalInvalid="Araç Önce Teslim Edilmeli.";

        public static string ImagesAdded="Resim Eklendi";
        public static string CarImageLimit = "5'den fazla resim ekleyemezsiniz.";

        public static string AuthorizationDenied="Giriş yapılamadı.";
        public static string UserRegistered="Kullanıcı Kaydedildi.";
        public static string UserNotFound="Kullanıcı Bulunamadı";
        public static string PasswordError="Şifre Yanlış";
        public static string SuccessfulLogin="Giriş Yapıldı";
        public static string UserAlreadyExists = "Kullanıcı Zaten Var";
        public static string AddedUser="Kullanıcı Eklnedi";
        public static string AccessTokenCreated="Token Üretildi.";
        
        public static string AccountAdded="Cart Eklendi";
        public static string AccountListed="Kartlar Listelendi.";
        public static string AccountUpdated="Ödeme Başarılı";
        public static string AccountDeleted="Hesap Başarıyla Silindi.";
    }
}
