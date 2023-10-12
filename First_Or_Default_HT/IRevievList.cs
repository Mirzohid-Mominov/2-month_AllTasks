using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//IReviewList<TReview> interfeysidan foydalaning, TReview ga IReview bilan constraint qo'ying

//unda quyidagi methodlar bo'lsin

//- Add ( review ) -reviewni reviewlar kolleksiyasiga qo'shsin
//- Update ( id, star, message ) -review ni update qilsin
//- Remove ( id ) -review ni kolleksiyadan o'chirsin
//- Remove ( review ) -kolleksiyadan berilgan review ni id bo'yicha qidirib, topilsa o'chirsin
//- GetReview ( id ) -reviewni id bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
//- GetReview ( message ) -review ni message bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
//- GetOverallReview - review lar bo'yicha umumiy xulosa ni string da chiqarsin


namespace First_Or_Default_HT
{
    public interface IRevievList<TReview> where  TReview : IReview
    {
        //- Add ( review ) -reviewni reviewlar kolleksiyasiga qo'shsin
        public void Add(TReview review);

        //- Update ( id, star, message ) -review ni update qilsin
        public void Update(Guid id, int star, string message);

        //- Remove ( id ) -review ni kolleksiyadan o'chirsin
        public void Remove(Guid id);

        //- Remove ( review ) -kolleksiyadan berilgan review ni id bo'yicha qidirib, topilsa o'chirsin
        public void Remove(TReview review);
        
        //- GetReview ( id ) -reviewni id bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
        TReview GetReview(Guid id);

        //- GetReview ( message ) -review ni message bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
        TReview GetReview(string message);

        //- GetOverallReview - review lar bo'yicha umumiy xulosa ni string da chiqarsin
        public void GetOverallReview();
    }
}
