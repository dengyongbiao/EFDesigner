//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
//
//     Produced by Entity Framework Visual Editor
//     https://github.com/msawczyn/EFDesigner
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

namespace Sandbox_EFCore
{
   public partial class User
   {
      partial void Init();

      /// <summary>
      /// Default constructor
      /// </summary>
      public User()
      {
         Init();
      }

      /*************************************************************************
       * Persistent properties
       *************************************************************************/

      /// <summary>
      /// Identity, Required, Indexed
      /// </summary>
      [Key]
      [Required]
      public long Id { get; private set; }

      /// <summary>
      /// Indexed
      /// </summary>
      public string Property1 { get; set; }

      /*************************************************************************
       * Persistent navigation properties
       *************************************************************************/

      protected global::Sandbox_EFCore.Sandbox_EFCore _Role;
      partial void SetRole(global::Sandbox_EFCore.Sandbox_EFCore oldValue, ref global::Sandbox_EFCore.Sandbox_EFCore newValue);
      partial void GetRole(ref global::Sandbox_EFCore.Sandbox_EFCore result);

      public virtual global::Sandbox_EFCore.Sandbox_EFCore Role
      {
         get
         {
            global::Sandbox_EFCore.Sandbox_EFCore value = _Role;
            GetRole(ref value);
            return (_Role = value);
         }
         set
         {
            global::Sandbox_EFCore.Sandbox_EFCore oldValue = _Role;
            SetRole(oldValue, ref value);
            if (oldValue != value)
            {
               _Role = value;
            }
         }
      }

   }
}
