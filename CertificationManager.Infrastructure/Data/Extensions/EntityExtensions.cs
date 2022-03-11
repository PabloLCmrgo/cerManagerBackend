
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace CertificationManager.Infrastructure.Data.Extensions
{
    public static class EntityExtensions
    {
        /*
        public static IQueryable<Entities.Trip> IncludeNextEventWithAll(this IQueryable<Entities.Trip> query)
        {
            return query.Include(x => x.NextEvent)
                    //.ThenInclude(i => i.EventType)
                    .Include(x => x.NextEvent)
                        //.ThenInclude(i => i.EventLogStatus)
                        .Include(i => i.NextEvent.Location);
                 //.ThenInclude(i => i.Jurisdiction);
        }

        public static IQueryable<Entities.Trip> IncludeNextFinalWithAll(this IQueryable<Entities.Trip> query)
        {
            return query.Include(x => x.FinalEvent)
                    //.ThenInclude(i => i.EventType)
                    .Include(x => x.FinalEvent)
                        //.ThenInclude(i => i.EventLogStatus)
                        .Include(i => i.FinalEvent.Location);
                 //.ThenInclude(i => i.Jurisdiction);
        }
        public static IQueryable<Entities.Trip> IncludeActiveTripEvents(this IQueryable<Entities.Trip> query)
        {
            return query.Include(i => i.TripEvents.Where(x => !x.IsRowDeleted).OrderBy(x => x.SequenceId))
                    //.ThenInclude(i => i.Truck)
                    .Include(i => i.TripEvents)
                    //.ThenInclude(i => i.Trailer)
                    .Include(i => i.TripEvents)
                    //.ThenInclude(i => i.EventType)
                    .Include(i => i.TripEvents);
                        //.ThenInclude(i => i.Location)
                        //.ThenInclude(i => i.Jurisdiction);
        }
        */
        public static IQueryable<T> AddConditionIfValue<T>(this IQueryable<T> query, int? property, Expression<Func<T, bool>> predicate) =>
            property != null && property > 0 ? query.Where(predicate) : query;

        public static IQueryable<T> AddConditionIfValue<T>(this IQueryable<T> query, string property, Expression<Func<T, bool>> predicate) =>
            !string.IsNullOrWhiteSpace(property) ? query.Where(predicate) : query;

        public static IQueryable<T> AddConditionIfValue<T>(this IQueryable<T> query, bool condition, Expression<Func<T, bool>> predicate) =>
            condition ? query.Where(predicate) : query;

        public static Expression<Func<T, bool>> CombineAsOrElse<T>(this IEnumerable<Expression<Func<T, bool>>> preds)
        {
            var par = Expression.Parameter(typeof(T), "x");

            Expression body = Expression.Constant(false);

            foreach (var pred in preds)
            {
                body = Expression.OrElse(body, Expression.Invoke(pred, par));
            }

            return Expression.Lambda(body, par) as Expression<Func<T, bool>>;
        }
    }
}
