﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.VUZ
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Group.
    /// </summary>
    // *** Start programmer edit section *** (Group CustomAttributes)

    // *** End programmer edit section *** (Group CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("GroupE", new string[] {
            "Number as \'Number\'",
            "Faculty as \'Faculty\'",
            "Faculty.Name as \'Name\'"})]
    [View("GroupL", new string[] {
            "Number as \'Number\'",
            "Faculty.Name as \'Name\'"})]
    public class Group : ICSSoft.STORMNET.DataObject
    {
        
        private int fNumber;
        
        private IIS.VUZ.Faculty fFaculty;
        
        // *** Start programmer edit section *** (Group CustomMembers)

        // *** End programmer edit section *** (Group CustomMembers)

        
        /// <summary>
        /// Number.
        /// </summary>
        // *** Start programmer edit section *** (Group.Number CustomAttributes)

        // *** End programmer edit section *** (Group.Number CustomAttributes)
        public virtual int Number
        {
            get
            {
                // *** Start programmer edit section *** (Group.Number Get start)

                // *** End programmer edit section *** (Group.Number Get start)
                int result = this.fNumber;
                // *** Start programmer edit section *** (Group.Number Get end)

                // *** End programmer edit section *** (Group.Number Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Group.Number Set start)

                // *** End programmer edit section *** (Group.Number Set start)
                this.fNumber = value;
                // *** Start programmer edit section *** (Group.Number Set end)

                // *** End programmer edit section *** (Group.Number Set end)
            }
        }
        
        /// <summary>
        /// Group.
        /// </summary>
        // *** Start programmer edit section *** (Group.Faculty CustomAttributes)

        // *** End programmer edit section *** (Group.Faculty CustomAttributes)
        [PropertyStorage(new string[] {
                "Faculty"})]
        [NotNull()]
        public virtual IIS.VUZ.Faculty Faculty
        {
            get
            {
                // *** Start programmer edit section *** (Group.Faculty Get start)

                // *** End programmer edit section *** (Group.Faculty Get start)
                IIS.VUZ.Faculty result = this.fFaculty;
                // *** Start programmer edit section *** (Group.Faculty Get end)

                // *** End programmer edit section *** (Group.Faculty Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Group.Faculty Set start)

                // *** End programmer edit section *** (Group.Faculty Set start)
                this.fFaculty = value;
                // *** Start programmer edit section *** (Group.Faculty Set end)

                // *** End programmer edit section *** (Group.Faculty Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "GroupE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View GroupE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("GroupE", typeof(IIS.VUZ.Group));
                }
            }
            
            /// <summary>
            /// "GroupL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View GroupL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("GroupL", typeof(IIS.VUZ.Group));
                }
            }
        }
    }
}