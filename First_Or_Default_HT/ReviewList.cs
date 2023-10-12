using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ReviewList<TReview> modelidan foydalaning, unda IReviewList<TReview> ni impleemnt qiling
//bunda GetOverallReview bunday ishlashi kerak : 

//agar
//- reviewlar soni 0 bo'lsa - "Be the first to leave a review for this product"
//- reviewlar barchasi 5 star bo'lsa - "Great news! All reviews for this product are 5-star ratings."
//- agar reviewlar orasida 1 star bo'lsa - o'sha reviewdagi message chiqsin

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
    internal class ReviewList<TReview> : IRevievList<TReview> where TReview : IReview
    {
        private List<TReview> _reviews = new();

        //- Add ( review ) -reviewni reviewlar kolleksiyasiga qo'shsin
        public void Add(TReview review)
        {
            _reviews.Add(review);
        }

        //- Update ( id, star, message ) -review ni update qilsin
        public void Update(Guid id, int star, string message)
        {
            var review = _reviews.First(review => review.Id == id);
            review.Star = star;
            review.Message = message;
        }

        //- Remove ( id ) -kolleksiyadan berilgan review ni id bo'yicha qidirib, topilsa o'chirsin
        public void Remove(Guid id)
        {
            _reviews.Remove(_reviews.FirstOrDefault(review => review.Id == id));
        }

        //- Remove ( review) -review ni kolleksiyadan o'chirsin
        public void Remove(TReview review)
        {
            _reviews.Remove(review);
        }

        //- GetReview ( id ) -reviewni id bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
        TReview IRevievList<TReview>.GetReview(Guid id)
        {
            return _reviews.Find(review => review.Id == id);
        }

        //- GetReview ( message ) -review ni message bo'yicha topib qaytarsin, bo'lmasa null qaytarsin
        TReview IRevievList<TReview>.GetReview(string message)
        {
            return _reviews.Find(messages => messages.Message == message);
        }

        //- GetOverallReview - review lar bo'yicha umumiy xulosa ni string da chiqarsin
        //agar
        //- reviewlar soni 0 bo'lsa - "Be the first to leave a review for this product"
        //- reviewlar barchasi 5 star bo'lsa - "Great news! All reviews for this product are 5-star ratings."
        //- agar reviewlar orasida 1 star bo'lsa - o'sha reviewdagi message chiqsin
        public void GetOverallReview()
        {
            if(!_reviews.Any())
            {
                Console.WriteLine("Be the first to leave a review for this product");
                return;
            }

            if (_reviews.All(review => review.Star == 5))
            {
                Console.WriteLine("Great News! All reviews for this product are 5 star raitings");
                return;
            }

            var review = _reviews.FirstOrDefault(review => review.Star == 1);
            if (review != null)
            {
                Console.WriteLine(review.Message);
            }

        }

       
    }
}

