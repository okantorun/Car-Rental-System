using Core.Entities.Concrate;
using Core.Utilities.Security.JWT;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string CarAdded = "Araba ekleme işlemi başarılı";
        public static string CarDeleted = "Araba silme işlemi başarılı";
        public static string CarUpdated = "Araba güncelleme işlemi başarılı";
        public static string CarDescInvalid = "Araba açıklaması minumum 10 karakter olmalıdır";
        public static string CarListed = "Listeleme başarılı";
        public static string MaintenanceTime = "Sistem bakımdadır";
        public static string GeneralAdd = "Ekleme başarılı.";
        public static string GeneralUpdate = "Güncelleme başarılı.";
        public static string GeneralDelete = "Silme başarılı.";
        public static string CarHired = "Araba kiralama başarılı";
        public static string CarNotDelivered = "Araba kiralama başarısız.";
        public static string CarImageCountExceeded = "Araba resim sayısı limiti aşıldı";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı register oldu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token başarıyla oluşturuldu";
        public static string UserAdded = "Kullanıcı eklendi";
        public static string UserUpdated = "Kullanıcı güncellendi";
        public static string UserDeleted = "Kullanıcı silindi";
    }
}
