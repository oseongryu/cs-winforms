﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F5074.Winforms.MyForm.F_DBMS
{
    // http://www.csharpstudy.com/Practical/Prac-mongodb.aspx
    public partial class MyMongoDB01 : UserControl
    {
        public MyMongoDB01()
        {
            InitializeComponent();
            //Refresh();
        }

        //public void Refresh()
        //{
        //    // Mongo DB를 위한 Connection String
        //    string connString = "mongodb://localhost";

        //    // MongoClient 클라이언트 객체 생성
        //    MongoClient cli = new MongoClient(connString);

        //    // testdb 라는 데이타베이스 가져오기
        //    // 만약 해당 DB 없으면 Collection 생성시 새로 생성함
        //    MongoDatabase testdb = cli.GetServer().GetDatabase("testdb");

        //    // testdb 안에 Customers 라는 컬렉션(일종의 테이블)
        //    // 가져오기. 만약 없으면 새로 생성.
        //    var customers = testdb.GetCollection<Customer>("Customers");

        //    // INSERT - 컬렉션 객체의 Insert() 메서드 호출
        //    // Insert시 _id 라는 자동으로 ObjectID 생성 
        //    // 이 _id는 해당 다큐먼트는 나타는 키.
        //    Customer cust1 = new Customer { Name = "Kim", Age = 30 };
        //    customers.Insert(cust1);
        //    ObjectId id = cust1.Id;

        //    // SELECT - id로 검색
        //    IMongoQuery query = Query.EQ("_id", id);
        //    var result = customers.Find(query).SingleOrDefault();
        //    if (result != null)
        //    {
        //        Console.WriteLine(result.ToString());
        //    }

        //    // UPDATE
        //    //    Save() = 전체 다큐먼트 갱신.
        //    //    Update() = 부분 수정
        //    cust1.Age = 31;
        //    customers.Save(cust1);

        //    // DELETE
        //    var qry = Query.EQ("_id", id);
        //    customers.Remove(qry);
        //}
        //class Customer
        //{
        //    // 이 Id는 MongoDB Collection의 _id 컬럼과 매칭됨
        //    // (예외적인 Naming Convention)
        //    public ObjectId Id { get; set; }

        //    public string Name { get; set; }
        //    public int Age { get; set; }

        //    public override string ToString()
        //    {
        //        return Name + " " + Age;
        //    }
        //}
    }

}
