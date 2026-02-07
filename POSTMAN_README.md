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

المجموعة تحتوي على المتغيرات التالية (يجب تحديثها بمعلوماتك):

- **db_server**: اسم السيرفر الخاص بك (مثال: `DESKTOP-42E526E\MSSQLSERVER_2016`)
- **db_name**: `Compu_Pos`
- **db_user**: اسم المستخدم الخاص بك
- **db_password**: كلمة المرور الخاصة بك
- **connection_string**: السلسلة الكاملة للاتصال بقاعدة البيانات

#### تكوين بيانات الاعتماد الخاصة بك:

بعد استيراد الملفات إلى Postman:

1. افتح "Environments" من الشريط الجانبي الأيسر
2. اختر "Compu-Pos Database Environment"
3. قم بتحديث القيم التالية بمعلومات قاعدة البيانات الخاصة بك:
   - `db_server`: استبدل `YOUR_SERVER_NAME\INSTANCE_NAME` باسم السيرفر الخاص بك
   - `db_user`: استبدل `YOUR_USERNAME` باسم المستخدم الخاص بك
   - `db_password`: استبدل `YOUR_PASSWORD` بكلمة المرور الخاصة بك
4. احفظ التغييرات

**ملاحظة**: يمكنك نسخ معلومات الاتصال من ملف `appsettings.json` في المشروع.

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

The collection contains the following variables (you need to update them with your information):

- **db_server**: Your server name (example: `DESKTOP-42E526E\MSSQLSERVER_2016`)
- **db_name**: `Compu_Pos`
- **db_user**: Your username
- **db_password**: Your password
- **connection_string**: Complete database connection string

#### Configure Your Credentials:

After importing the files to Postman:

1. Open "Environments" from the left sidebar
2. Select "Compu-Pos Database Environment"
3. Update the following values with your database information:
   - `db_server`: Replace `YOUR_SERVER_NAME\INSTANCE_NAME` with your server name
   - `db_user`: Replace `YOUR_USERNAME` with your username
   - `db_password`: Replace `YOUR_PASSWORD` with your password
4. Save the changes

**Note**: You can copy the connection information from the `appsettings.json` file in the project.

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

**العربية**: 
- الملفات المُضمّنة في المشروع تحتوي على قيم نموذجية (placeholders) فقط
- يجب عليك تحديث بيانات الاعتماد (اسم المستخدم وكلمة المرور) في Postman بعد الاستيراد
- **لا تشارك** ملفات Postman التي تحتوي على بيانات الاعتماد الحقيقية
- **لا تقم برفع** ملفات تحتوي على كلمات مرور حقيقية إلى GitHub أو أي مستودع عام

**English**: 
- The files included in the project contain placeholder values only
- You must update the credentials (username and password) in Postman after importing
- **Do not share** Postman files that contain real credentials
- **Do not upload** files containing real passwords to GitHub or any public repository

### للمطورين / For Developers:

If you want to create a local copy with your actual credentials:
1. Copy `Compu_Pos.postman_environment.json` to `Compu_Pos.postman_environment.local.json`
2. Update the local file with your real credentials
3. The `.local.json` files are ignored by git and won't be committed
