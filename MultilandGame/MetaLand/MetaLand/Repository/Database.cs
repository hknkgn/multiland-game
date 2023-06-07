using ComponentFactory.Krypton.Toolkit;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace MetaLand.Repository
{
    public class Database
    {

        public static string connectionString = "Data Source=.;Initial Catalog=MetaLand;Integrated Security=True";
        public static string Query { get; set; }
        public Business Business { get; set; }
        public KullaniciIslem KullaniciIslem { get; set; }
        public Emlak Emlak { get; set; }

        static SqlConnection connection = new SqlConnection(connectionString);

        public int Login()
        {
            connection.Open();
            int isLogin;
            Query = "SELECT User_Name,User_ID,UserType,AmountFood, AmountItem, AmountMoney FROM Kullanicilar WHERE User_NickName = @Username AND User_Pass = @Password";
            using (SqlCommand command = new SqlCommand(Query, connection))
            {
                command.Parameters.AddWithValue("@Username", User.UserNickname);
                command.Parameters.AddWithValue("@Password", User.Password);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Read();
                    int userType = Convert.ToInt32(reader["UserType"]);
                    Amount.AmountMoney = Convert.ToInt32(reader["AmountMoney"]);
                    User.UserId = Convert.ToInt32(reader["User_ID"]);
                    User.UserName = reader["User_ID"].ToString();
                    Amount.AmountItem = Convert.ToInt32(reader["AmountItem"]);
                    Amount.AmountFood = Convert.ToInt32(reader["AmountFood"]);

                    isLogin = userType == 1 ? 1 : (userType == 0 ? 0 : 2);
                }
                else
                {
                    isLogin = 2;
                }
                reader.Close();
                connection.Close();
                return isLogin;
            }
        }
        public void Register(int type)
        {
            PullAmountData();
            connection.Open();
            Query = "Insert into Kullanicilar(User_Name,User_Surname,User_Pass,User_NickName,AmountFood,AmountItem,AmountMoney,GameStartDate,UserType) values(@name,@surname,@pass,@nickname,@food,@item,@money,@startdate,@usertype)";
            SqlCommand addData = new SqlCommand(Query, connection);
            addData.Parameters.AddWithValue("@name", User.UserName);
            addData.Parameters.AddWithValue("@surname", User.UserSurname);
            addData.Parameters.AddWithValue("@pass", User.Password);
            addData.Parameters.AddWithValue("@nickname", User.UserNickname);
            addData.Parameters.AddWithValue("@food", Amount.AmountFood);
            addData.Parameters.AddWithValue("@startdate", User.StartDate);
            addData.Parameters.AddWithValue("@money", Amount.AmountMoney);
            addData.Parameters.AddWithValue("@item", Amount.AmountItem);
            addData.Parameters.AddWithValue("@usertype", type);
            addData.ExecuteNonQuery();
            connection.Close();
        }

        public void PullAmountDataUser()//güncel
        {
            connection.Open();
            Query = "Select AmountFood, AmountItem, AmountMoney from Kullanicilar where User_ID = @userid";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            pulldata.Parameters.AddWithValue("@userid", User.UserId);
            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                Amount.AmountFood = Convert.ToInt32(reader["AmountFood"]);
                Amount.AmountMoney = Convert.ToInt32(reader["AmountMoney"]);
                Amount.AmountItem = Convert.ToInt32(reader["AmountItem"]);
            }
            reader.Close();
            connection.Close();
        }
        public void PullAmountData()
        {
            connection.Open();
            Query = "Select AmountFood, AmountItem, AmountMoney from BaslangicBakiye";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                Amount.AmountFood = Convert.ToInt32(reader["AmountFood"]);
                Amount.AmountMoney = Convert.ToInt32(reader["AmountMoney"]);
                Amount.AmountItem = Convert.ToInt32(reader["AmountItem"]);
            }
            reader.Close();
            connection.Close();
        }
        public void PullGameAreaData()
        {
            connection.Open();
            Query = "Select AreaHeight, AreaWidth from OyunAlani";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                GameSetting.AreaHeight = Convert.ToInt32(reader["AreaHeight"]);
                GameSetting.AreaWidth = Convert.ToInt32(reader["AreaWidth"]);
            }
            reader.Close();
            connection.Close();
        }

        public List<KeyValuePair<string, int>> PullAreaName()
        {
            List<KeyValuePair<string, int>> buttonNames = new List<KeyValuePair<string, int>>();

            connection.Open();
            Query = "Select AlanID,AlanAd From Arsalar";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            while (reader.Read())
            {

                string alanAd = reader["AlanAd"].ToString();
                int alanID = Convert.ToInt32(reader["AlanID"]);
                KeyValuePair<string, int> pair = new KeyValuePair<string, int>(alanAd, alanID);
                buttonNames.Add(pair);
            }
            reader.Close();
            connection.Close();
            return buttonNames;
        }
        public void SetUserData(DataGridView data)
        {
            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    int userId = Convert.ToInt32(row.Cells[0].Value);
                    string name = row.Cells[1].Value.ToString();
                    string surname = row.Cells[2].Value.ToString();
                    string nickname = row.Cells[3].Value.ToString();
                    string pass = row.Cells[4].Value.ToString();
                    string food = row.Cells[5].Value.ToString();
                    string item = row.Cells[6].Value.ToString();
                    string money = row.Cells[7].Value.ToString();
                    DateTime startdate = Convert.ToDateTime(row.Cells[8].Value);
                    bool type = Convert.ToBoolean(row.Cells[9].Value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "UPDATE Kullanicilar SET User_Name = @Username, User_NickName = @nickname, User_Pass = @pass, User_Surname = @surname,GameStartDate=@date,UserType=@usertype,AmountFood=@food WHERE User_ID = @UserId";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Username", name);
                            command.Parameters.AddWithValue("@surname", surname);
                            command.Parameters.AddWithValue("@nickname", nickname);
                            command.Parameters.AddWithValue("@pass", pass);
                            command.Parameters.AddWithValue("@usertype", type);
                            command.Parameters.AddWithValue("@food", food);
                            command.Parameters.AddWithValue("@item", item);
                            command.Parameters.AddWithValue("@money", money);
                            command.Parameters.AddWithValue("@date", startdate);
                            command.Parameters.AddWithValue("@UserId", userId);

                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
            }

        }
        public void PullBusinessData(int id)
        {
            connection.Open();
            Query = "Select IsletmeID, CalisanSayisi, Kapasite, SaatlikUcret," +
                "IsletmeSahibiID,IsletmeTürID,IsletmeUrunFiyat  from İsletme where ArsaId = @arsaıd";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            pulldata.Parameters.AddWithValue("@arsaıd", id);
            SqlDataReader reader = pulldata.ExecuteReader();
            Business = new Business();
            while (reader.Read())
            {
                Business.IsletmeID = Convert.ToInt32(reader["IsletmeID"]);
                Business.CalisanSayisi = Convert.ToInt32(reader["CalisanSayisi"]);
                Business.Kapasite = Convert.ToInt32(reader["Kapasite"]);
                Business.SaatlikUcret = Convert.ToInt32(reader["SaatlikUcret"]);
                Business.ArsaId = id;
                Business.IsletmeSahibiID = Convert.ToInt32(reader["IsletmeSahibiID"]);
                Business.IsletmeTurID = Convert.ToInt32(reader["IsletmeTürID"]);
                Business.IsletmeUrunFiyat = Convert.ToInt32(reader["IsletmeUrunFiyat"]);
            }
            reader.Close();
            connection.Close();
        }
        public void PullAreaName1()
        {

            int areaid = 0;
            connection.Open();
            Query = "Select AlanID, AlanAd, Owner From Arsalar";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            SqlDataReader reader = pulldata.ExecuteReader();
            List<GameSetting> buttonList = new List<GameSetting>();
            GameSetting gameSetting = new GameSetting();
            while (reader.Read())
            {
                gameSetting.AreaId = Convert.ToInt32(reader["AlanID"]);
                gameSetting.Name = reader["AlanAd"].ToString();
                gameSetting.AreaOwnerId = Convert.ToInt32(reader["Owner"]);
                buttonList.Add(gameSetting);
                areaid++;
            }
            reader.Close();
            connection.Close();
        }
        public void UpdateAmount()
        {
            connection.Open();
            Query = "UPDATE BaslangicBakiye SET AmountFood=@food,AmountMoney=@money,AmountItem=@item";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@food", Amount.AmountFood);
            command.Parameters.AddWithValue("@money", Amount.AmountMoney);
            command.Parameters.AddWithValue("@item", Amount.AmountItem);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void UpdateAreaSize()
        {
            connection.Open();
            Query = "UPDATE OyunAlani SET AreaWidth=@width,AreaHeight=@height";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@width", GameSetting.AreaWidth);
            command.Parameters.AddWithValue("@height", GameSetting.AreaHeight);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void CalismaIslemiKullaniciGonder(int money, int arsaid)
        {

            connection.Open();
            Query = "UPDATE Kullanicilar SET AmountFood = @AmountFood, AmountItem = @AmountItem, AmountMoney = @AmountMoney where User_ID = @UserId";
            SqlCommand command = new SqlCommand(Query, connection);
            if (Business.IsletmeTurID == 3)//emlak
            {
                command.Parameters.AddWithValue("@AmountFood", Amount.AmountFood - 10);
                command.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney + money);
                command.Parameters.AddWithValue("@AmountItem", Amount.AmountItem - 10);
            }
            else if (Business.IsletmeTurID == 2)//magaza
            {
                command.Parameters.AddWithValue("@AmountFood", Amount.AmountFood - 10);
                command.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney - 10 + money);
                command.Parameters.AddWithValue("@AmountItem", Amount.AmountItem);

            }
            else if (Business.IsletmeTurID == 1) //market
            {
                command.Parameters.AddWithValue("@AmountFood", Amount.AmountFood);
                command.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney - 10 + money);
                command.Parameters.AddWithValue("@AmountItem", Amount.AmountItem - 10);
            }
            command.Parameters.AddWithValue("@UserId", User.UserId);
            command.ExecuteNonQuery();

            string updateIsletmeQuery = " UPDATE İsletme SET Kapasite = Kapasite - 1, CalisanSayisi = CalisanSayisi + 1 WHERE İsletme.ArsaId = @arsaid";
            using (SqlCommand command1 = new SqlCommand(updateIsletmeQuery, connection))
            {
                command1.Parameters.AddWithValue("@arsaid", arsaid);

                command1.ExecuteNonQuery();
            }
            connection.Close();
        }
        public void KullaniciIslemKaydet(string olay)
        {
            connection.Open();
            KullaniciIslem = new KullaniciIslem();
            Query = "Insert into KullaniciIslemleri(Kimden,Kime,Olay,GerceklesmeZamani,KalanYiyecek,KalanEsya,KalanPara)values" +
                "(@kimden,@kime,@olay,@gerceklesmezamani,@food,@item,@money)";
            SqlCommand addData = new SqlCommand(Query, connection);
            KullaniciIslem.Kimden = Business.IsletmeSahibiID;
            KullaniciIslem.Kime = User.UserName;
            KullaniciIslem.Olay = olay;

            addData.Parameters.AddWithValue("@kimden", KullaniciIslem.Kimden);
            addData.Parameters.AddWithValue("@kime", KullaniciIslem.Kime);
            addData.Parameters.AddWithValue("@olay", KullaniciIslem.Olay);
            addData.Parameters.AddWithValue("@gerceklesmezamani", KullaniciIslem.GerceklesmeZamani);
            addData.Parameters.AddWithValue("@food", Amount.AmountFood);
            addData.Parameters.AddWithValue("@money", Amount.AmountMoney);
            addData.Parameters.AddWithValue("@item", Amount.AmountItem);
            addData.ExecuteNonQuery();
            connection.Close();
        }
        public void setUrunAlma(int total)
        {
            connection.Open();
            Query = "UPDATE Kullanicilar SET AmountFood = @AmountFood, AmountItem = @AmountItem, AmountMoney = @AmountMoney where User_ID = @UserId";
            SqlCommand command = new SqlCommand(Query, connection);
            if (Business.IsletmeTurID == 1)
            {
                command.Parameters.AddWithValue("@AmountFood", Amount.AmountFood + total / Business.IsletmeUrunFiyat);
                command.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney - total);
                command.Parameters.AddWithValue("@AmountItem", Amount.AmountItem);
                command.Parameters.AddWithValue("@UserId", User.UserId);
                command.ExecuteNonQuery();
                connection.Close();
            }
            else
            {
                command.Parameters.AddWithValue("@AmountFood", Amount.AmountFood);
                command.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney - total);
                command.Parameters.AddWithValue("@AmountItem", Amount.AmountItem + total / Business.IsletmeUrunFiyat);
                command.Parameters.AddWithValue("@UserId", User.UserId);
                command.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void pullEmlakData()
        {

            connection.Open();
            Query = "Select AliciKomisyon, IsletmeKiraUcreti, SaticiKomisyon, Emlak.SatanKiralayanKullanıcıID, Emlak.SatınAlanKiralayanKullanıcıID, IsletmeSatisUcreti, İslemTarihi, KiraBitisTarihi from Emlak where IsletmeId= @isletmeid";
            SqlCommand pulldata = new SqlCommand(Query, connection);
            pulldata.Parameters.AddWithValue("@isletmeid", Business.IsletmeID);
            Emlak = new Emlak();

            SqlDataReader reader = pulldata.ExecuteReader();
            if (reader.Read())
            {
                Emlak.IsletmeId = Business.IsletmeID;
                Emlak.AliciKomisyon = Convert.ToInt32(reader["AliciKomisyon"]);
                Emlak.SaticiKomisyon = Convert.ToInt32(reader["SaticiKomisyon"]);
                Emlak.SatanKiralayanKullaniciID = Convert.ToInt32(reader["SatanKiralayanKullanıcıID"]);
                Emlak.SatinAlanKiralayanKullaniciID = Convert.ToInt32(reader["SatınAlanKiralayanKullanıcıID"]);
                Emlak.IsletmeSatisUcreti = Convert.ToInt32(reader["IsletmeSatisUcreti"]);
                Emlak.IsletmeKiraUcreti = Convert.ToInt32(reader["IsletmeKiraUcreti"]);
                Emlak.IslemTarihi = Convert.ToDateTime(reader["İslemTarihi"]);
                Emlak.KiraBitisTarihi = Convert.ToDateTime(reader["KiraBitisTarihi"]);

            }
            reader.Close();
            connection.Close();
        }
        public DataTable userDetail()
        {
            connection.Open();
            string kayit = "SELECT * from Arsalar where Owner=@owner ";
            SqlCommand komut = new SqlCommand(kayit, connection);
            komut.Parameters.AddWithValue("@owner", User.UserId);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);

            connection.Close();
            return dt;
        }
        public DataTable userDetailInfo()
        {
            connection.Open();
            string kayit = "SELECT * from Kullanicilar where User_ID=@userid ";
            SqlCommand komut = new SqlCommand(kayit, connection);
            komut.Parameters.AddWithValue("@userid", User.UserId);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            connection.Close();
            return dt;
        }
        public void EmlakSatIslem()
        {
            connection.Open();
            Query = "update Emlak set SatanKiralayanKullanıcıID = 1 , SatınAlanKiralayanKullanıcıID=@satınalan,İslemTarihi=@tarih where IsletmeID=@isletmeid";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@SatanKiralayanKullanıcıID", Business.IsletmeSahibiID);
            command.Parameters.AddWithValue("@satınalan", User.UserId);
            command.Parameters.AddWithValue("@tarih", DateTime.Now);
            command.Parameters.AddWithValue("@isletmeid", Business.IsletmeID);
            command.ExecuteNonQuery();
            connection.Close();
        }
        public void BakiyeDüs()
        {
            connection.Open();
            Query = "UPDATE Kullanicilar SET AmountMoney = @AmountMoney where User_ID = @UserId";
            SqlCommand command = new SqlCommand(Query, connection);
            command.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney - Emlak.IsletmeSatisUcreti - Emlak.AliciKomisyon);
            command.Parameters.AddWithValue("@UserId", User.UserId);
            command.ExecuteNonQuery();

            //yükleme
            Query = "UPDATE Kullanicilar SET AmountMoney = @AmountMoney where User_ID = @UserId";
            SqlCommand cmd = new SqlCommand(Query, connection);
            cmd.Parameters.AddWithValue("@AmountMoney", Amount.AmountMoney + Emlak.IsletmeSatisUcreti - Emlak.SaticiKomisyon);
            cmd.Parameters.AddWithValue("@UserId", Business.IsletmeSahibiID);
            cmd.ExecuteNonQuery();

            Query = "UPDATE Arsalar SET Owner = @owner where AlanID = @alanid";
            SqlCommand arsa = new SqlCommand(Query, connection);
            arsa.Parameters.AddWithValue("@owner", User.UserId);
            arsa.Parameters.AddWithValue("@alanid", Business.ArsaId);
            arsa.ExecuteNonQuery();
            connection.Close();
        }
        /*public void UpdateArsaName() 
        {

            foreach (DataGridViewRow row in data.Rows)
            {
                if (row.IsNewRow)
                    continue;

                if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                {
                    int userId = Convert.ToInt32(row.Cells[0].Value);
                    string name = row.Cells[1].Value.ToString();
                    string surname = row.Cells[2].Value.ToString();
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string updateQuery = "Update Arsalar set AlanAd= @alanad where Owner=@owner";

                        using (SqlCommand command = new SqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Username", name);
                            command.Parameters.AddWithValue("@nickname", User.UserId);
                            command.ExecuteNonQuery();
                        }
                        connection.Close();
                    }
                }
            }

        }*/
    }
}

