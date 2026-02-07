# Compu-Pos Postman Collection

## العربية

### استيراد المجموعة إلى Postman

تحتوي هذه المجموعة على معلومات الاتصال بقاعدة بيانات Compu-Pos.

#### الخطوات:

1. افتح تطبيق Postman
2. اضغط على زر "Import" في الزاوية العلوية اليسرى
3. اسحب وأفلت الملفات التالية أو اضغط "Upload Files":
   - `Compu_Pos.postman_collection.json`
   - `Compu_Pos.postman_environment.json`
4. بعد الاستيراد، حدد البيئة "Compu-Pos Database Environment" من القائمة المنسدلة في أعلى اليمين
5. الآن يمكنك استخدام متغيرات الاتصال في طلباتك

#### معلومات الاتصال:

المجموعة تحتوي على المتغيرات التالية:

- **db_server**: `DESKTOP-42E526E\MSSQLSERVER_2016`
- **db_name**: `Compu_Pos`
- **db_user**: `sa`
- **db_password**: `6321`
- **connection_string**: السلسلة الكاملة للاتصال بقاعدة البيانات

#### الاستخدام:

يمكنك استخدام هذه المتغيرات في طلبات API الخاصة بك عن طريق:
- `{{db_server}}` - عنوان خادم قاعدة البيانات
- `{{db_name}}` - اسم قاعدة البيانات
- `{{db_user}}` - اسم المستخدم
- `{{db_password}}` - كلمة المرور
- `{{connection_string}}` - سلسلة الاتصال الكاملة

---

## English

### Import Collection to Postman

This collection contains connection information for the Compu-Pos database.

#### Steps:

1. Open Postman application
2. Click the "Import" button in the top-left corner
3. Drag and drop the following files or click "Upload Files":
   - `Compu_Pos.postman_collection.json`
   - `Compu_Pos.postman_environment.json`
4. After importing, select "Compu-Pos Database Environment" from the dropdown in the top-right
5. You can now use the connection variables in your requests

#### Connection Information:

The collection contains the following variables:

- **db_server**: `DESKTOP-42E526E\MSSQLSERVER_2016`
- **db_name**: `Compu_Pos`
- **db_user**: `sa`
- **db_password**: `6321`
- **connection_string**: Complete database connection string

#### Usage:

You can use these variables in your API requests by:
- `{{db_server}}` - Database server address
- `{{db_name}}` - Database name
- `{{db_user}}` - Username
- `{{db_password}}` - Password
- `{{connection_string}}` - Full connection string

---

## Files Included

1. **Compu_Pos.postman_collection.json** - The main Postman collection
2. **Compu_Pos.postman_environment.json** - Environment variables for database connection

## Security Note / ملاحظة أمنية

⚠️ **تحذير أمني / Security Warning**: 

**العربية**: هذه الملفات تحتوي على بيانات اعتماد حساسة (اسم المستخدم وكلمة المرور). يجب عدم مشاركتها في مستودعات عامة أو إرسالها لأشخاص غير موثوقين.

**English**: These files contain sensitive credentials (username and password). Do not share them in public repositories or send them to untrusted parties.
