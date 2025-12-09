# Geometrik Shakllar O‘lchamlarini Hisoblash

Bu dastur foydalanuvchi kiritgan ma’lumotlar asosida turli geometrik shakllarning perimetri, uzunligi va yuzini hisoblab beradi.

## ✨ Dastur imkoniyatlari

Quyidagi shakllar bilan ishlaydi:

| Shakl | Kod | Hisoblaydi |
|------|-----|------------|
| Doira | **D** | Diametri, uzunligi, yuzi |
| Uchburchak | **W** | Perimetri, yuzi (Geron formulasi orqali) |
| Teng tomonli uchburchak | **U** | Perimetri, balandligi, yuzi |
| Kvadrat | **K** | Perimetri, yuzi |
| To‘g‘ri burchakli to‘rtburchak | **T** | Perimetri, yuzi |

---

## 🔥 Foydalanish tartibi

Programma ishga tushgandan so‘ng:

1️⃣ Menyudan shakl turini belgilang (D/W/U/K/T)  
2️⃣ Kerakli o‘lchamlarni kiriting (radius, tomon uzunliklari va h.k.)  
3️⃣ Natijalar ekranga chiqariladi  
4️⃣ `"yes"` yozsangiz — dastur boshidan qayta ishlaydi  
   `"no"` yozsangiz — dastur tugaydi

---

## 🧮 Formulalar

| Shakl | Formulalar |
|------|------------|
| **Doira** | `P = 2*R`  `L = 2*π*R`  `S = π*R²` |
| **Uchburchak** | `P = a + b + c`  `S = √(p(p-a)(p-b)(p-c))` |
| **Teng tomonli uchburchak** | `P = 3*a` `h = (√3/2)*a` `S = (√3/4)*a²` |
| **Kvadrat** | `P = 4*a` `S = a²` |
| **To‘g‘ri burchakli to‘rtburchak** | `P = 2*(a + b)` `S = a*b` |

---

## ⚠️ Xatoliklarni tekshirish

- Tomonlar noto‘g‘ri kiritilsa
- Uchburchak tengsizlik shartiga to‘g‘ri kelmasa
- Raqam o‘rniga boshqa qiymat yozilsa  

Dastur xatolik haqida ogohlantiradi va yana urinib ko‘rishni taklif qiladi.

---

## ▶️ Ishga tushirish

Visual Studio yoki .NET SDK yordamida:

```bash
dotnet run
