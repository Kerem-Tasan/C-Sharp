using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SQLCSHARP
{ 
    internal class Program
    {
     static  SqlConnection con = new SqlConnection("Data Source=DESKTOP-NU8CJ8G;Initial Catalog=DbVisit;Integrated Security=True");
        static void Main(string[] args)
        {
          

            Console.WriteLine("Hoşgeldiniz!");
            listele();
            void systeminfo()

            { Console.WriteLine("0-)Çıkış\n" +
                              "1-)Listele\n"+
                              "2-)Ekle\n"+
                              "3-)Silme\n"+
                              "4-)Güncelleme\n");
          
               
            }
            systeminfo();


            Console.Write("Yapmak istediğiniz işlemi seçin:");
    int select = Convert.ToInt32(Console.ReadLine());

        

            systeminfo();


            while (select != 0){
             
               
                switch (select)
                {  
                    
                    
                    
                    
                case 0:

                        Console.WriteLine("Çıkış yapılıyor iyi günler");
                       

                        break;

                    case 1:

                        listele();
               
                        break;
                    case 2:

                        ekleme();
                        
                        break;


                    case 3:

                        delete();
                    
                        break;




                    case 4:
                        update();
                       
                        break;



                    default:
                        Console.WriteLine("Lütfen geçerli bir işlem kodu girin!");
                        break;
                }
                systeminfo();

                Console.Write("Yapmak istediğiniz işlemi seçin:");

                select = Convert.ToInt32(Console.ReadLine());
            }

            void listele()
            {

                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from TblPerson", con);
                SqlDataAdapter adapter = new SqlDataAdapter();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " | " + reader[1] + " | " + reader[2]);
                    Console.WriteLine("-----------------------------------");
                }

                con.Close();
            }

            //Ekleme işlemi
           



            //Silme
               void delete()
            {    listele();
        con.Open();
            
            
                  Console.Write("Silmek istediğiniz Kişinin Idsını girin:");
                  int IDdelete=Convert.ToInt32(Console.ReadLine()) ;
                
                  SqlCommand cmd3 = new SqlCommand("Delete from TblPerson where Id=@p1", con);
                
                  cmd3.Parameters.AddWithValue("@p1", IDdelete);
                  cmd3.ExecuteNonQuery();
                
         con.Close();

            }
           
            //Güncelleme İşlemi
      void update() {

                listele();
   con.Open() ;
                Console.WriteLine("Bilgisini değiştirmek  istediğiniz Kişinin Idsını girin:");
                int IDupdate = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Bilgisini değiştirdiğiniz kişinin ad soyad bilgisini giriniz:");
                String adupt = Console.ReadLine();
                Console.WriteLine("Değiştirdiğiniz kişinin ülkesi:");
                String ulkeupt = Console.ReadLine();

                SqlCommand cmd4 = new SqlCommand("update TblPerson set Name=@p1,City=@p2 where Id=@p3", con);

            cmd4.Parameters.AddWithValue("@p1", adupt );
            cmd4.Parameters.AddWithValue("@p2", ulkeupt);
            cmd4.Parameters.AddWithValue("@p3", IDupdate);
            cmd4.ExecuteNonQuery();
           con.Close() ;   
            
            


            
            }
         


           Console.ReadLine();
            //Data Source=DESKTOP-NU8CJ8G;Initial Catalog=DbVisit;Integrated Security=True
      
     void ekleme()
        {

            con.Open();
            Console.WriteLine("Eklemek istediğiniz ad soyad bilgisini giriniz:");
            String ad = Console.ReadLine();
            Console.WriteLine("Eklemek istediğiniz Ülke bilgisini giriniz");
            String ulke = Console.ReadLine();

            SqlCommand cmd2 = new SqlCommand("insert into TblPerson(Name,City) values (@p1,@p2)", con);

            cmd2.Parameters.AddWithValue("@p1", ad);
            cmd2.Parameters.AddWithValue("@p2", ulke);
            //veri tabanına kayıt eder işlemi.
            //
            cmd2.ExecuteNonQuery();

            con.Close();
            listele();

        }
  }

    }
}



