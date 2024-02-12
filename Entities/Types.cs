using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Types
{
    public enum InvoiceType
    {
        Bireysel = 1,
        Kurumsal = 2,
        Default = 0
    }
    public enum EDocumentType : int
    {

        EFatura = 1,
        EArsiv = 2,
        EBilet = 3

    }

    public enum DbType : int
    {
        Undefined = -2,
        Delete = -1,
        Passive = 0,
        Active = 1,
    }

    public enum DeviceType : int
    {
        Undefined = 0,
        Android = 1,
        IPhone = 2,
        Windows = 3,
        MacOS = 4,
        Linux = 5,
        Fuchsia = 6,

    }

    public enum ReservationStatus
    {
        Undefined = 0,
        New = 1,
        Replacing = 2,
        Changed = 3,
        Cancel = 4,
    }
    public enum SalesStep
    {
        Undefined = 0,
        Product = 1,
        Invoice = 2,
        Payment = 3,
        Voucher = 4
    }
    public enum CurrencyType
    {
        Undefined = 0,
        TurkLirasi = 1,
        Euro = 2,
        Dolar = 3
    }

    public enum PaymentType
    {
        Undefined = 0,
        VirtualPos = 1,
        Pos = 2,
        EftHavale = 3,
        Nakit = 4,
        Cari = 5,
        Discount = 6,
        Refund = 7,
        Subtraction = 8,
        GiroGate = 9


    }

    public enum UserType
    {
        System = 1,
        FerryPersonel = 2,
        Hotel = 3,

    }

    public enum RouteType : int
    {
        OneWay = 1,
        RoundTrip = 2,
        OpenReturn = 3,
        ReturnDifferentDay = 4,
        ReturnSameDay = 5,
        Undefined = 0

    }
    public enum EDocumentDirectionType : int
    {

        Gelen = 1,
        Giden = 2,
        Undefined = 0

    }

    public enum ProductType
    {
        Undefined = 0
       , PassengerFerryboat = 1
       , VehicleFerryboat = 2
       , ExtraHizmet = 3
       , Hotel = 4
       , Tour = 5
       , RoomClass = 6
       , ForthCrs = 7
       , PackageTour = 8
       , WebHotelier = 9
    }
}
