****---Script---**** 

Açıklama: Bir E-Ticaret satıcısı kendi web sitesinde ürünlerini satmaktadır. Siparişler web sitesi api lerinden belli aralıklara çekilecektir. Çekilen siparişler için not(comment) ekleyen bir api geliştirmesi yapılacaktır.
1.	Siparişleri çekip order_table a yazacak bir servis yazın. İl sipariş statüsü “received” olacaktır
2.	Order_comment tablosuna account_id , user_id , order_id inputları zorunlu olacak şekilde comment ekleyen , değiştiren ve silen bir web service yazın. 
3.	Sipariş durumlarını güncellemek için account_id, order_number inputları olacak şekilde bir web service yazın. 

****---Entities---****

**Order table :**
-	Account_id
-	Order_id
-	Order_number
-	Order_date
-	Order_type(default b2c)
-	Status(received,inprogress,pick,pack,ship,delivered)
-	Sales_channel
-	City(il)
-	District(ilçe)
-	Carrier(taşıyıcı firma kodu)
-	User_id
-	Created_at
-	Updated_at
  
**Order_comment table :**
-	İd
-	Order_id
-	User_id
-	Comment
-	Created_at
- Account_id
  
**User table :**
-	İd
-	User_name
-	Email
-	Password
-	Created_at

  
