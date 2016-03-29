using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using FreightAppASP.DataContexts;

namespace FreightAppASP.Models
{
    public static class SeedData
    {
        public static void Initialize(CarrierContext carrierContext)
        {
            var context = carrierContext;

            if (context.Database == null)
            {
                throw new Exception("DB is null");
            }

            /*if (context.Carriers.Any())
            {
                return;   // DB has been seeded
            }*/

            context.Carriers.AddRange(
                 new Carrier
                 {

                        DotNumber = 1234,
                        IsTaxtId = true,
                        CompanyName = "The Matrix Shipping",
                        DbaName = "Neo Anderson",
                        MailingAddress = "1234 Alphabet Dr.",
                        MailingCity = "Sacramento",
                        MailingState = "CA",
                        MailingZip = "95842",
                        PhysicalAddress = "4321 Tebahpla Way",
                        PhysicalCity = "Sacramento",
                        PhysicalState = "CA",
                        PhysicalZip = "95842",
                        Phone = "9165551209",
                        Fax = "9165553213",
                        PrimaryContactName = "Morpheus Hasalastname",
                        PrimaryContactPhone = "9165554321",
                        PrimaryContactEmail = "1337h4ck3r@aol.com",
                        DispatchContactName = "Trinity Something",
                        DispatchContactPhone = "9165554399",
                        DispatchContactEmail = "FollowtheWhiteRabbit@hotmale.com",
                        AccountingContactName = "Thatone Dude",
                        AccountingContactPhone = "9165557893",
                        AccountingContactEmail = "Forgotmyname@fluff.com"
                 },
               
                 new Carrier
                 {

                     DotNumber = 449832723,
                     IsTaxtId = true,
                     CompanyName = "Truck N Go Shipping",
                     DbaName = "Brian Spillner",
                     MailingAddress = "4389 Fiesta Ln.",
                     MailingCity = "Texasland",
                     MailingState = "TX",
                     MailingZip = "23425",
                     PhysicalAddress = "8903 Robust Rd.",
                     PhysicalCity = "Houston",
                     PhysicalState = "TX",
                     PhysicalZip = "24322",
                     Phone = "2345787632",
                     Fax = "8734929323",
                     PrimaryContactName = "Dominic Torreto",
                     PrimaryContactPhone = "1234567890",
                     PrimaryContactEmail = "FastCarz@csus.edu",
                     DispatchContactName = "Letty Torreto",
                     DispatchContactPhone = "4323341234",
                     DispatchContactEmail = "FakeAmnesia@hotmail.com",
                     AccountingContactName = "Roman Pierce",
                     AccountingContactPhone = "3427895656",
                     AccountingContactEmail = "MyMovieSucked@fluff.com"
                 },
               
                 new Carrier
                 {

                     DotNumber = 348234,
                     IsTaxtId = true,
                     CompanyName = "We Move Your Cars Dot Com",
                     DbaName = "Ralph Machio",
                     MailingAddress = "9393 This Ln.",
                     MailingCity = "Bangarang",
                     MailingState = "GA",
                     MailingZip = "44442",
                     PhysicalAddress = "9211 Bored Hwy.",
                     PhysicalCity = "Bangarang",
                     PhysicalState = "GA",
                     PhysicalZip = "44442",
                     Phone = "9554451209",
                     Fax = "955433213",
                     PrimaryContactName = "Mr. Miyagi",
                     PrimaryContactPhone = "9655254321",
                     PrimaryContactEmail = "waxonwaxoff@aol.com",
                     DispatchContactName = "The Evil Kid",
                     DispatchContactPhone = "9553354399",
                     DispatchContactEmail = "IFightDirtyxx@hotmale.com",
                     AccountingContactName = "Ralphs Mom",
                     AccountingContactPhone = "955117893",
                     AccountingContactEmail = "ThisIsTedious@failzone.com"
                 },
               
                 new Carrier
                 {

                     DotNumber = 442212334,
                     IsTaxtId = false,
                     CompanyName = "Homeward Bound",
                     DbaName = "Spike Lee",
                     MailingAddress = "243423 Bet Rd.",
                     MailingCity = "Las Vegas",
                     MailingState = "NV",
                     MailingZip = "12312",
                     PhysicalAddress = "32 Tebahpla Way",
                     PhysicalCity = "Las Vegas",
                     PhysicalState = "NV",
                     PhysicalZip = "12312",
                     Phone = "5654645891",
                     Fax = "5654651581",
                     PrimaryContactName = "Rod Rodriguez",
                     PrimaryContactPhone = "5654884948",
                     PrimaryContactEmail = "HotRod123@aol.com",
                     DispatchContactName = "John Johnson",
                     DispatchContactPhone = "5654569446",
                     DispatchContactEmail = "Thecardood@email.com",
                     AccountingContactName = "Frank Tank",
                     AccountingContactPhone = "5651157893",
                     AccountingContactEmail = "Fname@fluff.com"
                 },
                
                 new Carrier
                 {

                     DotNumber = 12333224,
                     IsTaxtId = true,
                     CompanyName = "We Dont Do Shipping",
                     DbaName = "George Washington",
                     MailingAddress = "6 MLK Blvd.",
                     MailingCity = "Kansas City",
                     MailingState = "KA",
                     MailingZip = "23456",
                     PhysicalAddress = "6 MLK Blvd.",
                     PhysicalCity = "Kansas City",
                     PhysicalState = "KA",
                     PhysicalZip = "23456",
                     Phone = "9876567894",
                     Fax = "9875553213",
                     PrimaryContactName = "Abraham Lincoln",
                     PrimaryContactPhone = "9874448796",
                     PrimaryContactEmail = "Honestabe@aol.com",
                     DispatchContactName = "John Adams",
                     DispatchContactPhone = "9871563548",
                     DispatchContactEmail = "DShiznit@gmail.com",
                     AccountingContactName = "Thomas Jefferson",
                     AccountingContactPhone = "9875557893",
                     AccountingContactEmail = "DontCareanymore@outlook.com"
                 },
                
                 new Carrier
                 {

                     DotNumber = 9934,
                     IsTaxtId = true,
                     CompanyName = "ABCarriers",
                     DbaName = "",
                     MailingAddress = "1234 Alphabet Dr.",
                     MailingCity = "Sacramento",
                     MailingState = "CA",
                     MailingZip = "95842",
                     PhysicalAddress = "4321 Tebahpla Way",
                     PhysicalCity = "Sacramento",
                     PhysicalState = "CA",
                     PhysicalZip = "95842",
                     Phone = "9165551209",
                     Fax = "9165553213",
                     PrimaryContactName = "Morpheus Hasalastname",
                     PrimaryContactPhone = "9165554321",
                     PrimaryContactEmail = "1337h4ck3r@aol.com",
                     DispatchContactName = "Trinity Something",
                     DispatchContactPhone = "9165554399",
                     DispatchContactEmail = "FollowtheWhiteRabbit@hotmale.com",
                     AccountingContactName = "Thatone Dude",
                     AccountingContactPhone = "9165557893",
                     AccountingContactEmail = "Forgotmyname@fluff.com"
                 },
                 
                 new Carrier
                 {

                     DotNumber = 1234,
                     IsTaxtId = true,
                     CompanyName = "The Matrix Shipping",
                     DbaName = "Neo Anderson",
                     MailingAddress = "1234 Alphabet Dr.",
                     MailingCity = "Sacramento",
                     MailingState = "CA",
                     MailingZip = "95842",
                     PhysicalAddress = "4321 Tebahpla Way",
                     PhysicalCity = "Sacramento",
                     PhysicalState = "CA",
                     PhysicalZip = "95842",
                     Phone = "9165551209",
                     Fax = "9165553213",
                     PrimaryContactName = "Morpheus Hasalastname",
                     PrimaryContactPhone = "9165554321",
                     PrimaryContactEmail = "1337h4ck3r@aol.com",
                     DispatchContactName = "Trinity Something",
                     DispatchContactPhone = "9165554399",
                     DispatchContactEmail = "FollowtheWhiteRabbit@hotmale.com",
                     AccountingContactName = "Thatone Dude",
                     AccountingContactPhone = "9165557893",
                     AccountingContactEmail = "Forgotmyname@fluff.com"
                 },
               
                 new Carrier
                 {

                     DotNumber = 1234,
                     IsTaxtId = true,
                     CompanyName = "The Matrix Shipping",
                     DbaName = "Neo Anderson",
                     MailingAddress = "1234 Alphabet Dr.",
                     MailingCity = "Sacramento",
                     MailingState = "CA",
                     MailingZip = "95842",
                     PhysicalAddress = "4321 Tebahpla Way",
                     PhysicalCity = "Sacramento",
                     PhysicalState = "CA",
                     PhysicalZip = "95842",
                     Phone = "9165551209",
                     Fax = "9165553213",
                     PrimaryContactName = "Morpheus Hasalastname",
                     PrimaryContactPhone = "9165554321",
                     PrimaryContactEmail = "1337h4ck3r@aol.com",
                     DispatchContactName = "Trinity Something",
                     DispatchContactPhone = "9165554399",
                     DispatchContactEmail = "FollowtheWhiteRabbit@hotmale.com",
                     AccountingContactName = "Thatone Dude",
                     AccountingContactPhone = "9165557893",
                     AccountingContactEmail = "Forgotmyname@fluff.com"
                 },
                
                 new Carrier
                 {

                     DotNumber = 1234,
                     IsTaxtId = true,
                     CompanyName = "The Matrix Shipping",
                     DbaName = "Neo Anderson",
                     MailingAddress = "1234 Alphabet Dr.",
                     MailingCity = "Sacramento",
                     MailingState = "CA",
                     MailingZip = "95842",
                     PhysicalAddress = "4321 Tebahpla Way",
                     PhysicalCity = "Sacramento",
                     PhysicalState = "CA",
                     PhysicalZip = "95842",
                     Phone = "9165551209",
                     Fax = "9165553213",
                     PrimaryContactName = "Morpheus Hasalastname",
                     PrimaryContactPhone = "9165554321",
                     PrimaryContactEmail = "1337h4ck3r@aol.com",
                     DispatchContactName = "Trinity Something",
                     DispatchContactPhone = "9165554399",
                     DispatchContactEmail = "FollowtheWhiteRabbit@hotmale.com",
                     AccountingContactName = "Thatone Dude",
                     AccountingContactPhone = "9165557893",
                     AccountingContactEmail = "Forgotmyname@fluff.com"
                 },

                
                 new Carrier
                 {
                     DotNumber = 1234,
                     IsTaxtId = true,
                     CompanyName = "The Matrix Shipping",
                     DbaName = "Neo Anderson",
                     MailingAddress = "1234 Alphabet Dr.",
                     MailingCity = "Sacramento",
                     MailingState = "CA",
                     MailingZip = "95842",
                     PhysicalAddress = "4321 Tebahpla Way",
                     PhysicalCity = "Sacramento",
                     PhysicalState = "CA",
                     PhysicalZip = "95842",
                     Phone = "9165551209",
                     Fax = "9165553213",
                     PrimaryContactName = "Morpheus Hasalastname",
                     PrimaryContactPhone = "9165554321",
                     PrimaryContactEmail = "1337h4ck3r@aol.com",
                     DispatchContactName = "Trinity Something",
                     DispatchContactPhone = "9165554399",
                     DispatchContactEmail = "FollowtheWhiteRabbit@hotmale.com",
                     AccountingContactName = "Thatone Dude",
                     AccountingContactPhone = "9165557893",
                     AccountingContactEmail = "Forgotmyname@fluff.com"
                 }

                    );
            context.SaveChanges();
        }
    }
}
