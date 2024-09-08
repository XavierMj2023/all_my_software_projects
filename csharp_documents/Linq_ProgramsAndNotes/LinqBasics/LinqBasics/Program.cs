using LinqBasics;
using LinqBasics.LinqStandardOperators;

public class Program
{
    public static void Main(string[] args)
    {
        /*
         * Basic LINQ
         * 
         * SimpleLINQ_Query.ExecuteQuery();
         */
        //----------------------------------------------------------------
        /*
         * Why LINQ ?
         * 
         * WhyLinq.GetResultForWithLinq();
         * 
         * ----------------------------------------------------------------
         */
        /* Simple LINQ Query Syntax
         * 
         * LinqQuerySyntaxDemo.LinqQuerySyntax();
         * 
         * ----------------------------------------------------------------
         */
        /*
         * Simple LINQ Method Syntax
         * 
         * LinqMethodSyntaxDemo.ExecuteMethodSyntax_SecondExample();
         *
         *------------------------------------------------------------------
         */
        /*
         * Lambda Expression
         * 
         * LambdaExpression.GetResultTeenager();
         * 
         * -----------------------------------------------------------------
         */
        /*
         * Where - Filtering Standard Operator
         * 
         * Where.GetMultipleWhereUsingMethodSyntax();
         *
         * -----------------------------------------------------------------
        /*
         * 
         * OfType - Filtering Standard Operator
         * 
         * OfType.GetResultMethodSyntax_OfType();
         * 
         * -----------------------------------------------------------------
         */
        /*
         * 
         * OrderBy - Sorting Operator
         * 
         * OrderBy.GetMethodSyntaxOrderBy();
         * 
         * -----------------------------------------------------------------
         */
        /*
         * 
         * Order By Descending - Sorting Operator
         * 
         * OrderByDescending.GetOrderByDescending();
         * 
         * -----------------------------------------------------------------
         *
         */
        /*
         * 
         * Multiple Sorting - Sorting Using Query Syntax (Order By)
         * 
         * MultipleSorting.MultipleSortWithCurlyBraces();
         * 
         * ------------------------------------------------------------------
         * 
         */
        /*
         * 
         * ThenBy - Sorting Operator
         * 
         * ThenBy.GetThenByResult();
         * 
         * -----------------------------------------------------------------
         * 
         */
        /*
         * 
         * ThenByDescending - Sorting Operator
         * 
         * ThenByDescending.ThenByDescendingOps();
         * 
         * -----------------------------------------------------------------
         * 
         */
        /*
         * 
         *  GroupBy - Grouping Opeartor
         *  
         *  GroupBy.GetGroupByMethodSyntax();
         *  
         *  -----------------------------------------------------------------
         *  
         */
        /*
         * 
         *  ToLookUp - Grouping Operator
         * 
         *  ToLookUp.ToLookUpMethodSyntax();
         *  
         *  ------------------------------------------------------------------
         *  
         */
        /*
         * 
         *  Join - Joining Operators
         *  
         *  Join.GetJoinQuerySyntax();
         *  
         *  --------------------------------------------------------------------
         *  
         */
        /*
         * 
         * GroupJoin - Joining Operators
         * 
         * Join_GroupJoin.GetGroupJoinQuerySyntax();
         * 
         * --------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Select - Projection Operators
         * 
         * Select.GetSelectInMethodSyntax();
         * 
         * ---------------------------------------------------------------------
         * 
         */
        /* All ,Any - Quantifiers
         * 
         * All.ResultTeenagers(); //False               Any.AnyOps(); //True
         * 
         * ----------------------------------------------------------------------
         * 
        */
        /*
         * Contains - Quantifiers
         * 
         * Contains.GetContainsIEqualityComperer_For_SecondOverload();
         * 
         * -----------------------------------------------------------------------
         */
        /*
         * Aggregate - Aggregation
         * 
         * Aggregate.GetAggregateResultSelector();
         * 
         * ------------------------------------------------------------------------
         */
        /*
         * Average - Aggregation
         * 
         * Average.AverageAgeOfTeenager();
         * 
         * ------------------------------------------------------------------------
         */
        /*
         * Count - Aggregation
         * 
         * Count.CountTeensWrapQuerySyntax();
         * 
         * ------------------------------------------------------------------------
         */
        /*
         *
         * Max - Aggragation
         * 
         * Max.FindLargest();
         * 
         * ------------------------------------------------------------------------
         */
        /*
         * 
         * Sum - Aggregation
         * 
         * Sum.CalculateAgeSum();
         * 
         * ------------------------------------------------------------------------
         */
        /*
         * 
         * Element Operators - ElementAt and ElementAtOrDefault
         * 
         * ElementAt.ElementAtOrDefaultError();
         * 
         * ------------------------------------------------------------------------
         */
        /*
         * 
         * Element Operators - First and FirstOrDefault
         * 
         * ElementOperators.ExecuteFirstOrDefaultErrorNull();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Element Operators - Last and LastOrDefault
         * 
         * ElementOperators.ExecuteLastOrDefaultErrorNull();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Element Operators - Single and SingleOrDefault
         * 
         * ElementOperators.ExecuteSingleOrDefaultError();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Equality Operator - SequenceEqual
         * 
         * SequenceEqual.ExecuteSequenceEqualIEqualityComparer();
         * 
         * ------------------------------------------------------------------------
         *
        /*
         * 
         * Concatenation Operator - Concat
         * 
         * Concat.ExecuteConcat();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Sets Operators-Distinct,Except,Union,Intersect
         * 
         * Sets.ExecuteUnionOps();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Partitioning-Skip,SkipWhile,Take,TakeWhile
         * 
         * Partitioning.ExecuteTakeWhileOpSecondOverload();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Generation Operators: Empty
         * 
         * GenerationOperatorEmpty.EmptyOp();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Generation Operators: Range
         * 
         * GenerationOperatorRange.RangeOps();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Generation Operators: Repeat
         * 
         * GenerationOperatorsRepeat.RepeatOps();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Generation Operators: DefaultIfEmpty
         * 
         * GenerationOperatorsDefaultIfEmpty.DefaultIfEmptyForObjectOps();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Conversion Operators: AsEnumerable and AsQueryable
         * 
         * ConversionOperatorsAsEnumerable.ConvertToAsEnumerable();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Conversion Operators: Cast
         * 
         * ConversionOperatorsCast.ConvertToCast();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Conversion Operators: ToArray,ToList
         * 
         * ToConvertSomethingOps.ToArrayToListOps();
         * 
         * ------------------------------------------------------------------------
         * 
         */
        /*
         * 
         * Conversion Operators: ToDictonary
         * 
         * ToDictonary.ToDictonaryOps();
         * 
         * ------------------------------------------------------------------------
         * 
         */
    }
}