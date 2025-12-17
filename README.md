# 🎨 Geometrik Shakllar Hisoblash Dasturi

Bu loyiha **C# Console Application** bo‘lib, foydalanuvchiga turli geometrik shakllarning perimetri, yuzi va boshqa o‘lchamlarini hisoblash imkonini beradi. Loyiha **OOP tamoyillari** asosida yozilgan va interaktiv menyu orqali ishlaydi.

---

## 📌 Loyihaning asosiy imkoniyatlari

* ➕ Turli shakllar uchun o‘lchamlarni kiritish
* 📏 Doira, uchburchak, teng tomonli uchburchak, kvadrat va to‘g‘ri burchakli to‘rtburchakni hisoblash
* 📋 Perimetr, yuzi, diametr, balandlik kabi natijalarni chiqarish
* 🔄 Dastur ishga tushirilgandan so‘ng qayta ishlash imkoniyati
* ⚠️ Noto‘g‘ri kirishlarda ogohlantirish

---

## 🧱 Arxitektura tuzilmasi

Loyiha 3 ta asosiy qismdan iborat:

### 1️⃣ Hisoblash funksiyalari (Shapes Logic)

📂 `Program.cs` ichida har bir shakl uchun alohida metodlar mavjud:  

```csharp
static void Doira(double R) { ... }
static void Uchburchak(double a, double b, double c) { ... }
static void TengTomonliUchburchak(double a) { ... }
static void Kvadrat(double a) { ... }
static void TogriBurchakliTortburchak(double a, double b) { ... }
