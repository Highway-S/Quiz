# Quiz

- ชื่อ: ภูรินท์ วงศ์วัลลภ
- รหัสนักศึกษา: 673450199-6

## คำอธิบายโปรแกรม
โปรแกรมนี้ออกแบบมาเพื่อบันทึกข้อมูลนักศึกษาและอาจารย์ที่ปรึกษา โดยสามารถทำการบันทึกข้อมูลของนักศึกษา เช่น รหัสนักศึกษา ชื่อนามสกุล สาขาที่เรียน และอาจารย์ที่ปรึกษา ในขณะเดียวกัน อาจารย์สามารถมีนักศึกษาในที่ปรึกษาหลายคนได้ โดยนักศึกษาจะมีอาจารย์ที่ปรึกษาแค่คนเดียวเท่านั้น นอกจากนี้โปรแกรมยังสามารถแสดงรายชื่อนักศึกษาของอาจารย์ได้ รวมถึงการแสดงนักศึกษาที่ได้คะแนนเกรดสูงสุดในระบบ

## คำถามที่เกี่ยวข้อง

### 1. **Class Diagram ของโปรแกรมที่ออกแบบ**

โปรแกรมที่ออกแบบมี 3 คลาสหลักคือ:
- `Person` - คลาสพื้นฐานที่ใช้สำหรับเก็บข้อมูลพื้นฐานของทั้งนักศึกษาและอาจารย์
- `Student` - คลาสที่สืบทอดมาจาก `Person` ซึ่งมีคุณสมบัติเพิ่มเติมเกี่ยวกับนักศึกษา เช่น รหัสนักศึกษา, เกรด และอาจารย์ที่ปรึกษา
- `Advisor` - คลาสที่สืบทอดมาจาก `Person` ซึ่งมีคุณสมบัติเพิ่มเติมเกี่ยวกับอาจารย์ที่ปรึกษา เช่น รายชื่อนักศึกษาที่ดูแล

**Class Diagram**:

```plaintext
+------------------+        +--------------------+         +--------------------+
|     Person      |        |       Student      |         |     Advisor        |
+------------------+        +--------------------+         +--------------------+
| - Name: string   |<>------| - ID: string       |         | - advisees: List   |
| - Department: string|     | - Grade: double    |         | + AddStudent()      |
+------------------+        | - Advisor: Advisor |         | + GetStudentNames() |
                            +--------------------+         +--------------------+


### 2. **โปรแกรมได้ใช้หลักการเขียนโปรแกรมตามหลักการเขียนโปรแกรมเชิงวัตถุอย่างไรบ้าง**
โปรแกรมนี้ใช้หลักการเขียนโปรแกรมเชิงวัตถุ (OOP) ดังนี้:

Encapsulation (การห่อหุ้มข้อมูล):

ข้อมูลของนักศึกษาและอาจารย์ถูกห่อหุ้มไว้ในคลาส Student และ Advisor ซึ่งมีการกำหนด access modifiers (เช่น private และ public) เพื่อป้องกันการเข้าถึงข้อมูลภายนอกคลาสโดยตรง
Abstraction (การซ่อนรายละเอียด):

โปรแกรมใช้คลาส Student และ Advisor เพื่อซ่อนรายละเอียดของการทำงานภายในแต่ละคลาสจากผู้ใช้ เช่น วิธีการเพิ่มนักศึกษาของอาจารย์และการแสดงรายชื่อนักศึกษาของอาจารย์
Polymorphism (การหลายรูปแบบ):

การใช้ inheritance (การสืบทอดคลาส) จากคลาส Person ไปยัง Student และ Advisor ช่วยให้สามารถใช้เมธอดและคุณสมบัติที่คล้ายกัน (เช่น Name, Department) กับทั้งนักศึกษาและอาจารย์ได้ โดยไม่ต้องเขียนโค้ดซ้ำ
Inheritance (การสืบทอด):

คลาส Student และ Advisor สืบทอดจากคลาส Person ซึ่งช่วยให้สามารถใช้คุณสมบัติที่คล้ายกันระหว่างนักศึกษาและอาจารย์ได้ โดยไม่ต้องทำซ้ำในแต่ละคลาส