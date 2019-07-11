﻿//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
#region EDM 關聯性中繼資料

[assembly: EdmRelationshipAttribute("SchoolDBModel", "FK__Student__ClassId__1B0907CE", "Teacher", System.Data.Metadata.Edm.RelationshipMultiplicity.One, typeof(School.Data.Teacher), "Student", System.Data.Metadata.Edm.RelationshipMultiplicity.Many, typeof(School.Data.Student), true)]

#endregion

namespace School.Data
{
    #region 內容
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    public partial class SchoolDBEntities : ObjectContext
    {
        #region 建構函式
    
        /// <summary>
        /// 使用在應用程式組態檔的 'SchoolDBEntities' 區段中找到的連接字串，初始化新的 SchoolDBEntities 物件。
        /// </summary>
        public SchoolDBEntities() : base("name=SchoolDBEntities", "SchoolDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 SchoolDBEntities 物件。
        /// </summary>
        public SchoolDBEntities(string connectionString) : base(connectionString, "SchoolDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// 初始化新的 SchoolDBEntities 物件。
        /// </summary>
        public SchoolDBEntities(EntityConnection connection) : base(connection, "SchoolDBEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region 部分方法
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet 屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        public ObjectSet<Student> Students
        {
            get
            {
                if ((_Students == null))
                {
                    _Students = base.CreateObjectSet<Student>("Students");
                }
                return _Students;
            }
        }
        private ObjectSet<Student> _Students;
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        public ObjectSet<Teacher> Teachers
        {
            get
            {
                if ((_Teachers == null))
                {
                    _Teachers = base.CreateObjectSet<Teacher>("Teachers");
                }
                return _Teachers;
            }
        }
        private ObjectSet<Teacher> _Teachers;

        #endregion

        #region AddTo 方法
    
        /// <summary>
        /// 將新物件加入 Students EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToStudents(Student student)
        {
            base.AddObject("Students", student);
        }
    
        /// <summary>
        /// 將新物件加入 Teachers EntitySet 的方法已被取代。請考慮改為使用關聯的 ObjectSet&lt;T&gt; 屬性的 .Add 方法。
        /// </summary>
        public void AddToTeachers(Teacher teacher)
        {
            base.AddObject("Teachers", teacher);
        }

        #endregion

    }

    #endregion

    #region 實體
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolDBModel", Name="Student")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Student : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Student 物件。
        /// </summary>
        /// <param name="id">Id 屬性的初始值。</param>
        /// <param name="firstName">FirstName 屬性的初始值。</param>
        /// <param name="lastName">LastName 屬性的初始值。</param>
        /// <param name="dateOfBirth">DateOfBirth 屬性的初始值。</param>
        /// <param name="classId">ClassId 屬性的初始值。</param>
        public static Student CreateStudent(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.DateTime dateOfBirth, global::System.Int32 classId)
        {
            Student student = new Student();
            student.Id = id;
            student.FirstName = firstName;
            student.LastName = lastName;
            student.DateOfBirth = dateOfBirth;
            student.ClassId = classId;
            return student;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.DateTime DateOfBirth
        {
            get
            {
                return _DateOfBirth;
            }
            set
            {
                OnDateOfBirthChanging(value);
                ReportPropertyChanging("DateOfBirth");
                _DateOfBirth = StructuralObject.SetValidValue(value, "DateOfBirth");
                ReportPropertyChanged("DateOfBirth");
                OnDateOfBirthChanged();
            }
        }
        private global::System.DateTime _DateOfBirth;
        partial void OnDateOfBirthChanging(global::System.DateTime value);
        partial void OnDateOfBirthChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 ClassId
        {
            get
            {
                return _ClassId;
            }
            set
            {
                OnClassIdChanging(value);
                ReportPropertyChanging("ClassId");
                _ClassId = StructuralObject.SetValidValue(value, "ClassId");
                ReportPropertyChanged("ClassId");
                OnClassIdChanged();
            }
        }
        private global::System.Int32 _ClassId;
        partial void OnClassIdChanging(global::System.Int32 value);
        partial void OnClassIdChanged();

        #endregion

        #region 導覽屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SchoolDBModel", "FK__Student__ClassId__1B0907CE", "Teacher")]
        public Teacher Teacher
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher").Value;
            }
            set
            {
                ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher").Value = value;
            }
        }
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [BrowsableAttribute(false)]
        [DataMemberAttribute()]
        public EntityReference<Teacher> TeacherReference
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedReference<Teacher>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Teacher", value);
                }
            }
        }

        #endregion

    }
    
    /// <summary>
    /// 沒有可用的中繼資料文件。
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="SchoolDBModel", Name="Teacher")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class Teacher : EntityObject
    {
        #region Factory 方法
    
        /// <summary>
        /// 建立新 Teacher 物件。
        /// </summary>
        /// <param name="id">Id 屬性的初始值。</param>
        /// <param name="firstName">FirstName 屬性的初始值。</param>
        /// <param name="lastName">LastName 屬性的初始值。</param>
        /// <param name="class">Class 屬性的初始值。</param>
        public static Teacher CreateTeacher(global::System.Int32 id, global::System.String firstName, global::System.String lastName, global::System.String @class)
        {
            Teacher teacher = new Teacher();
            teacher.Id = id;
            teacher.FirstName = firstName;
            teacher.LastName = lastName;
            teacher.Class = @class;
            return teacher;
        }

        #endregion

        #region 簡單屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 Id
        {
            get
            {
                return _Id;
            }
            set
            {
                if (_Id != value)
                {
                    OnIdChanging(value);
                    ReportPropertyChanging("Id");
                    _Id = StructuralObject.SetValidValue(value, "Id");
                    ReportPropertyChanged("Id");
                    OnIdChanged();
                }
            }
        }
        private global::System.Int32 _Id;
        partial void OnIdChanging(global::System.Int32 value);
        partial void OnIdChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false, "FirstName");
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, false, "LastName");
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Class
        {
            get
            {
                return _Class;
            }
            set
            {
                OnClassChanging(value);
                ReportPropertyChanging("Class");
                _Class = StructuralObject.SetValidValue(value, false, "Class");
                ReportPropertyChanged("Class");
                OnClassChanged();
            }
        }
        private global::System.String _Class;
        partial void OnClassChanging(global::System.String value);
        partial void OnClassChanged();

        #endregion

        #region 導覽屬性
    
        /// <summary>
        /// 沒有可用的中繼資料文件。
        /// </summary>
        [XmlIgnoreAttribute()]
        [SoapIgnoreAttribute()]
        [DataMemberAttribute()]
        [EdmRelationshipNavigationPropertyAttribute("SchoolDBModel", "FK__Student__ClassId__1B0907CE", "Student")]
        public EntityCollection<Student> Students
        {
            get
            {
                return ((IEntityWithRelationships)this).RelationshipManager.GetRelatedCollection<Student>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Student");
            }
            set
            {
                if ((value != null))
                {
                    ((IEntityWithRelationships)this).RelationshipManager.InitializeRelatedCollection<Student>("SchoolDBModel.FK__Student__ClassId__1B0907CE", "Student", value);
                }
            }
        }

        #endregion

    }

    #endregion

}
