using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using NgDataSync.Core.Model;

namespace NgDataSync.Core.ViewModel
{
    //[Serializable]
    //[DataContract]
    public abstract class BaseViewModel : PersistentEntity
    {
        /// <summary>
        /// The primary key for all entities...
        /// </summary>
        //[DataMember]
        //[Key]
        //public int Id { get; set; }

        /// <summary>
        /// The time when the entity was first created.
        /// </summary>
        //[DataMember]
        //public string Created { get; set; }

        /// <summary>
        /// The time when the entity was last saved/updated.
        /// </summary>
        //[DataMember]
        //public string Updated { get; set; }

        protected BaseViewModel(PersistentEntity entity)
        {
            this.Id = entity.Id;
            this.Created = entity.Created;
            this.Updated = entity.Updated;
        }

        protected BaseViewModel() { }
    }
}
