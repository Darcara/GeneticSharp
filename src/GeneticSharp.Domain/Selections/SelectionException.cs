﻿using System;
using System.Runtime.Serialization;

namespace GeneticSharp
{
    /// <summary>
    /// Exception throw when an error occurs during the execution of selection.
    /// </summary>
    [Serializable]
    public sealed class SelectionException : Exception
    {
        #region Constructors
        /// <summary>
        /// Initializes a new instance of the <see cref="GeneticSharp.Domain.Selections.SelectionException"/> class.
        /// </summary>
        /// <param name="selection">The Selection where occurred the error.</param>
        /// <param name="message">The error message.</param>
        public SelectionException(ISelection selection, string message)
            : base("{0}: {1}".With(selection != null ? selection.GetType().Name : String.Empty, message))
        {
            Selection = selection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GeneticSharp.Domain.Selections.SelectionException"/> class.
        /// </summary>
        /// <param name="selection">The Selection where occurred the error.</param>
        /// <param name="message">The error message.</param>
        /// <param name="innerException">The inner exception.</param>
        public SelectionException(ISelection selection, string message, Exception innerException)
            : base("{0}: {1}".With(selection != null ? selection.GetType().Name : String.Empty, message), innerException)
        {
            Selection = selection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionException"/> class.
        /// </summary>
        public SelectionException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionException"/> class.
        /// </summary>
        /// <param name="message">The message that describes the error.</param>
        public SelectionException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionException"/> class.
        /// </summary>
        /// <param name="message">The error message that explains the reason for the exception.</param>
        /// <param name="innerException">The exception that is the cause of the current exception, or a null reference (Nothing in Visual Basic) if no inner exception is specified.</param>
        public SelectionException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SelectionException"/> class.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        private SelectionException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
        #endregion

        #region Properties
        /// <summary>
        /// Gets the Selection.
        /// </summary>
        /// <value>The Selection.</value>
        public ISelection Selection { get; private set; }
        #endregion

        #region Methods
        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("Selection", Selection);
        }
        #endregion
    }
}