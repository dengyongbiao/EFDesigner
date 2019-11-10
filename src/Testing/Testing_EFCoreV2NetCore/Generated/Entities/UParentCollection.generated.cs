//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Testing
{
   public partial class UParentCollection
   {
      partial void Init();

      /// <summary>
      /// Default constructor. Protected due to required properties, but present because EF needs it.
      /// </summary>
      protected UParentCollection()
      {
         Init();
      }

      /// <summary>
      /// Public constructor with required data
      /// </summary>
      /// <param name="uchildrequired"></param>
      public UParentCollection(global::Testing.UChild uchildrequired)
      {
         if (uchildrequired == null) throw new ArgumentNullException(nameof(uchildrequired));
         this.UChildRequired = uchildrequired;


         Init();
      }

      /// <summary>
      /// Static create function (for use in LINQ queries, etc.)
      /// </summary>
      /// <param name="uchildrequired"></param>
      public static UParentCollection Create(global::Testing.UChild uchildrequired)
      {
         return new UParentCollection(uchildrequired);
      }

      /*************************************************************************
       * Properties
       *************************************************************************/

      /// <summary>
      /// Backing field for Id
      /// </summary>
      protected int _Id;
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before setting.
      /// </summary>
      partial void SetId(int oldValue, ref int newValue);
      /// <summary>
      /// When provided in a partial class, allows value of Id to be changed before returning.
      /// </summary>
      partial void GetId(ref int result);

      /// <summary>
      /// Identity, Indexed, Required
      /// </summary>
      [Key]
      [Required]
      public int Id
      {
         get
         {
            int value = _Id;
            GetId(ref value);
            return (_Id = value);
         }
         protected set
         {
            int oldValue = _Id;
            SetId(oldValue, ref value);
            if (oldValue != value)
            {
               _Id = value;
            }
         }
      }

      /*************************************************************************
       * Navigation properties
       *************************************************************************/

      /// <summary>
      /// Required
      /// </summary>
      public virtual global::Testing.UChild UChildRequired { get; set; }

      public virtual global::Testing.UChild UChildOptional { get; set; }

   }
}

