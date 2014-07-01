/*
 * [The "BSD license"]
 *  Copyright (c) 2013 Terence Parr
 *  Copyright (c) 2013 Sam Harwell
 *  All rights reserved.
 *
 *  Redistribution and use in source and binary forms, with or without
 *  modification, are permitted provided that the following conditions
 *  are met:
 *
 *  1. Redistributions of source code must retain the above copyright
 *     notice, this list of conditions and the following disclaimer.
 *  2. Redistributions in binary form must reproduce the above copyright
 *     notice, this list of conditions and the following disclaimer in the
 *     documentation and/or other materials provided with the distribution.
 *  3. The name of the author may not be used to endorse or promote products
 *     derived from this software without specific prior written permission.
 *
 *  THIS SOFTWARE IS PROVIDED BY THE AUTHOR ``AS IS'' AND ANY EXPRESS OR
 *  IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED WARRANTIES
 *  OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED.
 *  IN NO EVENT SHALL THE AUTHOR BE LIABLE FOR ANY DIRECT, INDIRECT,
 *  INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT
 *  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE,
 *  DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY
 *  THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT
 *  (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF
 *  THIS SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
 */
using System.Collections.Generic;
using Antlr4.Runtime.Misc;
using Sharpen;

namespace Antlr4.Runtime.Misc
{
    /// <summary>A generic set of integers.</summary>
    /// <remarks>A generic set of integers.</remarks>
    /// <seealso cref="IntervalSet">IntervalSet</seealso>
    public interface IIntSet
    {
        /// <summary>Adds the specified value to the current set.</summary>
        /// <remarks>Adds the specified value to the current set.</remarks>
        /// <param name="el">the value to add</param>
        /// <exception>
        /// IllegalStateException
        /// if the current set is read-only
        /// </exception>
        void Add(int el);

        /// <summary>
        /// Modify the current
        /// <see cref="IIntSet">IIntSet</see>
        /// object to contain all elements that are
        /// present in itself, the specified
        /// <code>set</code>
        /// , or both.
        /// </summary>
        /// <param name="set">
        /// The set to add to the current set. A
        /// <code>null</code>
        /// argument is
        /// treated as though it were an empty set.
        /// </param>
        /// <returns>
        /// 
        /// <code>this</code>
        /// (to support chained calls)
        /// </returns>
        /// <exception>
        /// IllegalStateException
        /// if the current set is read-only
        /// </exception>
        [return: NotNull]
        IIntSet AddAll(IIntSet set);

        /// <summary>
        /// Return a new
        /// <see cref="IIntSet">IIntSet</see>
        /// object containing all elements that are
        /// present in both the current set and the specified set
        /// <code>a</code>
        /// .
        /// </summary>
        /// <param name="a">
        /// The set to intersect with the current set. A
        /// <code>null</code>
        /// argument is treated as though it were an empty set.
        /// </param>
        /// <returns>
        /// A new
        /// <see cref="IIntSet">IIntSet</see>
        /// instance containing the intersection of the
        /// current set and
        /// <code>a</code>
        /// . The value
        /// <code>null</code>
        /// may be returned in
        /// place of an empty result set.
        /// </returns>
        [return: Nullable]
        IIntSet And(IIntSet a);

        /// <summary>
        /// Return a new
        /// <see cref="IIntSet">IIntSet</see>
        /// object containing all elements that are
        /// present in
        /// <code>elements</code>
        /// but not present in the current set. The
        /// following expressions are equivalent for input non-null
        /// <see cref="IIntSet">IIntSet</see>
        /// instances
        /// <code>x</code>
        /// and
        /// <code>y</code>
        /// .
        /// <ul>
        /// <li>
        /// <code>x.complement(y)</code>
        /// </li>
        /// <li>
        /// <code>y.subtract(x)</code>
        /// </li>
        /// </ul>
        /// </summary>
        /// <param name="elements">
        /// The set to compare with the current set. A
        /// <code>null</code>
        /// argument is treated as though it were an empty set.
        /// </param>
        /// <returns>
        /// A new
        /// <see cref="IIntSet">IIntSet</see>
        /// instance containing the elements present in
        /// <code>elements</code>
        /// but not present in the current set. The value
        /// <code>null</code>
        /// may be returned in place of an empty result set.
        /// </returns>
        [return: Nullable]
        IIntSet Complement(IIntSet elements);

        /// <summary>
        /// Return a new
        /// <see cref="IIntSet">IIntSet</see>
        /// object containing all elements that are
        /// present in the current set, the specified set
        /// <code>a</code>
        /// , or both.
        /// <p>
        /// This method is similar to
        /// <see cref="AddAll(IIntSet)">AddAll(IIntSet)</see>
        /// , but returns a new
        /// <see cref="IIntSet">IIntSet</see>
        /// instance instead of modifying the current set.</p>
        /// </summary>
        /// <param name="a">
        /// The set to union with the current set. A
        /// <code>null</code>
        /// argument
        /// is treated as though it were an empty set.
        /// </param>
        /// <returns>
        /// A new
        /// <see cref="IIntSet">IIntSet</see>
        /// instance containing the union of the current
        /// set and
        /// <code>a</code>
        /// . The value
        /// <code>null</code>
        /// may be returned in place of an
        /// empty result set.
        /// </returns>
        [return: Nullable]
        IIntSet Or(IIntSet a);

        /// <summary>
        /// Return a new
        /// <see cref="IIntSet">IIntSet</see>
        /// object containing all elements that are
        /// present in the current set but not present in the input set
        /// <code>a</code>
        /// .
        /// The following expressions are equivalent for input non-null
        /// <see cref="IIntSet">IIntSet</see>
        /// instances
        /// <code>x</code>
        /// and
        /// <code>y</code>
        /// .
        /// <ul>
        /// <li>
        /// <code>y.subtract(x)</code>
        /// </li>
        /// <li>
        /// <code>x.complement(y)</code>
        /// </li>
        /// </ul>
        /// </summary>
        /// <param name="a">
        /// The set to compare with the current set. A
        /// <code>null</code>
        /// argument is treated as though it were an empty set.
        /// </param>
        /// <returns>
        /// A new
        /// <see cref="IIntSet">IIntSet</see>
        /// instance containing the elements present in
        /// <code>elements</code>
        /// but not present in the current set. The value
        /// <code>null</code>
        /// may be returned in place of an empty result set.
        /// </returns>
        [return: Nullable]
        IIntSet Subtract(IIntSet a);

        /// <summary>Return the total number of elements represented by the current set.</summary>
        /// <remarks>Return the total number of elements represented by the current set.</remarks>
        /// <returns>
        /// the total number of elements represented by the current set,
        /// regardless of the manner in which the elements are stored.
        /// </returns>
        int Size();

        /// <summary>
        /// Returns
        /// <code>true</code>
        /// if this set contains no elements.
        /// </summary>
        /// <returns>
        /// 
        /// <code>true</code>
        /// if the current set contains no elements; otherwise,
        /// <code>false</code>
        /// .
        /// </returns>
        bool IsNil();

        /// <summary><inheritDoc></inheritDoc></summary>
        bool Equals(object obj);

        /// <summary>
        /// Returns the single value contained in the set, if
        /// <see cref="Size()">Size()</see>
        /// is 1;
        /// otherwise, returns
        /// <see cref="Antlr4.Runtime.IToken.InvalidType">Antlr4.Runtime.IToken.InvalidType</see>
        /// .
        /// </summary>
        /// <returns>
        /// the single value contained in the set, if
        /// <see cref="Size()">Size()</see>
        /// is 1;
        /// otherwise, returns
        /// <see cref="Antlr4.Runtime.IToken.InvalidType">Antlr4.Runtime.IToken.InvalidType</see>
        /// .
        /// </returns>
        int GetSingleElement();

        /// <summary>
        /// Returns
        /// <code>true</code>
        /// if the set contains the specified element.
        /// </summary>
        /// <param name="el">The element to check for.</param>
        /// <returns>
        /// 
        /// <code>true</code>
        /// if the set contains
        /// <code>el</code>
        /// ; otherwise
        /// <code>false</code>
        /// .
        /// </returns>
        bool Contains(int el);

        /// <summary>Removes the specified value from the current set.</summary>
        /// <remarks>
        /// Removes the specified value from the current set. If the current set does
        /// not contain the element, no changes are made.
        /// </remarks>
        /// <param name="el">the value to remove</param>
        /// <exception>
        /// IllegalStateException
        /// if the current set is read-only
        /// </exception>
        void Remove(int el);

        /// <summary>Return a list containing the elements represented by the current set.</summary>
        /// <remarks>
        /// Return a list containing the elements represented by the current set. The
        /// list is returned in ascending numerical order.
        /// </remarks>
        /// <returns>
        /// A list containing all element present in the current set, sorted
        /// in ascending numerical order.
        /// </returns>
        [return: NotNull]
        IList<int> ToList();

        /// <summary><inheritDoc></inheritDoc></summary>
        string ToString();
    }
}
