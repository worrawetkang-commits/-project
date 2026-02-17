



# 🛒 Project Foodgrade Store (Product Management & Receipt System)

โปรเจคนี้เป็นระบบจัดการร้านค้า Foodgrade
พัฒนาโดยใช้ **Windows Forms (C# .NET)** และฐานข้อมูล **SQLite**
สามารถจัดการข้อมูลสินค้า และออกใบเสร็จเป็น PDF ได้

---

## 👥 สมาชิก

**วรเวทย์ เกงขุนทด** : UX/UI Design / Coding / GitHub
**อาทิตย์ กุลมาตย์** : UX/UI Design / Diagram / Coding

---

# ✅ Features (ความสามารถ)

* เพิ่มข้อมูลสินค้า (Auto Generate ID)
* แก้ไขข้อมูลสินค้าด้วย ProductID
* ลบข้อมูลสินค้าด้วย ProductID
* แสดงข้อมูลในตาราง DataGridView
* คำนวณยอดขายอัตโนมัติ
* ออกใบเสร็จเป็นไฟล์ PDF
* บันทึกไฟล์ใบเสร็จลงในโฟลเดอร์ Downloads

---

# 📌 Project Overview

ระบบ Foodgrade Store เป็นโปรแกรมบริหารจัดการร้านค้า
พัฒนาโดยใช้ Windows Forms (C#) และ SQLite Database

ระบบออกแบบโดยใช้หลักการ OOP เพื่อให้โครงสร้างชัดเจน แบ่งหน้าที่เป็นสัดส่วน และสามารถพัฒนาต่อยอดได้

### 🔹 ระบบสามารถทำงานได้ดังนี้

* เพิ่ม / แก้ไข / ลบ ข้อมูลสินค้า (CRUD)
* ค้นหาสินค้าด้วย ProductID
* จัดการสต็อกสินค้า
* ออกใบเสร็จ PDF อัตโนมัติ
* บันทึกข้อมูลลงฐานข้อมูล SQLite

---

# 🎯 วัตถุประสงค์ของโครงการ

* ฝึกการพัฒนา CRUD กับ Database
* ฝึกการเชื่อมต่อ SQLite ใน C#
* ฝึกการสร้างไฟล์ PDF ด้วย iTextSharp
* ฝึกการทำงานเป็นทีมผ่าน GitHub
* พัฒนาระบบร้านค้าให้สามารถใช้งานได้จริง

---

# ⚙️ Technologies Used

* C# Windows Forms (.NET)
* SQLite Database
* Microsoft.Data.Sqlite
* iTextSharp.LGPLv2.Core (PDF Generator)
* Visual Studio 2022
* Git & GitHub
* PlantUML / Draw.io (Class Diagram)

---

# ✅ Prerequisites

ก่อนใช้งานโปรเจคนี้ ต้องมีสิ่งต่อไปนี้:

* Windows OS
* Visual Studio 2022
* .NET SDK 6.0 หรือสูงกว่า
* NuGet Package Manager
* Git

---

# 💻 Installation Guide

## 1️⃣ Clone Project จาก GitHub

```bash
git clone https://github.com/yourusername/FoodgradeStore.git
cd FoodgradeStore
```

หรือ Clone ผ่าน Visual Studio:

* เปิด Visual Studio
* เลือก Clone Repository
* วางลิงก์ GitHub
* กด Clone

---

## 2️⃣ เปิดโปรเจค

* เปิดไฟล์ `.sln`
* กด Build → Build Solution

---

## 3️⃣ ติดตั้ง NuGet Packages (ถ้ายังไม่มี)

ไปที่
Tools → NuGet Package Manager → Manage NuGet Packages

ติดตั้ง:

* Microsoft.Data.Sqlite
* iTextSharp.LGPLv2.Core

---

## 4️⃣ Run โปรแกรม

กดปุ่ม ▶ Start หรือกด F5

---

# 📖 User Manual

## 🔐 หน้า Login

* กรอก Username / Password
* กด Login เพื่อเข้าสู่ระบบ

📸 (ใส่ Screenshot หน้า Login)

---

## 📦 หน้า Manage Product

* กด Add เพื่อเพิ่มสินค้า
* กด Update เพื่อแก้ไขสินค้า
* กด Delete เพื่อลบสินค้า
* ดูข้อมูลใน DataGridView

📸 (ใส่ Screenshot หน้า Product Form)

---

## 🧾 หน้า Receipt

* เลือกสินค้า
* ใส่จำนวน
* ระบบคำนวณราคารวม
* กด Generate PDF เพื่อออกใบเสร็จ

📸 (ใส่ Screenshot หน้า Receipt)

---

# 🗂 Source Code Structure

```
FoodgradeStore/
│
├── Models/
│   ├── Product.cs
│   ├── Receipt.cs
│   └── User.cs
│
├── Services/
│   ├── ProductService.cs
│   └── ReceiptService.cs
│
├── Forms/
│   ├── LoginForm.cs
│   ├── ProductForm.cs
│   └── ReceiptForm.cs
│
├── Database/
│   └── DatabaseHelper.cs
│
├── App.config
└── Program.cs
```

---

# 📊 Class Diagram (แนวคิด)

### Class Product

* ProductID
* Name
* Price
* Stock

### Class Receipt

* ReceiptID
* Date
* TotalAmount
* List<Product>

### Class User

* UserID
* Username
* Password

ความสัมพันธ์:

* Receipt ประกอบด้วย Product หลายรายการ
* User เป็นผู้ใช้งานระบบ

---

# 🔗 GitHub Repository

ระบบนี้ใช้ GitHub สำหรับ Version Control
สามารถดูประวัติการ Commit และการทำงานเป็นทีมได้ใน Repository

---


