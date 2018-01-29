using System.Collections.Generic;

namespace Match.Domain
{
    public abstract class Entity<TId>
    {
        protected Entity(TId id)
        {
            Id = id;
        }

        public TId Id { get; private set; }

        public override bool Equals(object entity)
        {
            var entity1 = entity as Entity<TId>;
            if (entity1 == null)
            {
                return false;
            }

            return EqualityComparer<TId>.Default.Equals(Id, entity1.Id);
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        public static bool operator ==(Entity<TId> entity1, Entity<TId> entity2)
        {
            if ((object)entity1 == null && (object)entity2 == null)
            {
                return true;
            }
            if ((object)entity1 == null || (object)entity2 == null)
            {
                return false;
            }

            return EqualityComparer<TId>.Default.Equals(entity1.Id, entity2.Id);
        }

        public static bool operator !=(Entity<TId> entity1, Entity<TId> entity2)
        {
            return !(entity1 == entity2);
        }
    }
}