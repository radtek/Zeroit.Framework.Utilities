// ***********************************************************************
// Assembly         : Zeroit.Framework.Utilities
// Author           : ZEROIT
// Created          : 11-22-2018
//
// Last Modified By : ZEROIT
// Last Modified On : 12-21-2018
// ***********************************************************************
// <copyright file="Configurator.cs" company="Zeroit Dev Technologies">
//     Copyright � Zeroit Dev Technologies  2017. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Globalization;
using System.Reflection;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerDateTimeHumanizeStrategy;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerLocalisation.Formatters;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerLocalisation.NumberToWords;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerLocalisation.Ordinalizers;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerLocalisation.CollectionFormatters;
using Zeroit.Framework.Utilities.StringProcessing.HumanizerLocalisation.DateToOrdinalWords;

namespace Zeroit.Framework.Utilities.StringProcessing.HumanizerConfiguration
{
    /// <summary>
    /// Provides a configuration point for Humanizer
    /// </summary>
    public static class Configurator
    {
        /// <summary>
        /// The collection formatters
        /// </summary>
        private static readonly LocaliserRegistry<ICollectionFormatter> _collectionFormatters = new CollectionFormatterRegistry();

        /// <summary>
        /// A registry of formatters used to format collections based on the current locale
        /// </summary>
        /// <value>The collection formatters.</value>
        public static LocaliserRegistry<ICollectionFormatter> CollectionFormatters
        {
            get { return _collectionFormatters; }
        }

        /// <summary>
        /// The formatters
        /// </summary>
        private static readonly LocaliserRegistry<IFormatter> _formatters = new FormatterRegistry();
        /// <summary>
        /// A registry of formatters used to format strings based on the current locale
        /// </summary>
        /// <value>The formatters.</value>
        public static LocaliserRegistry<IFormatter> Formatters
        {
            get { return _formatters; }
        }

        /// <summary>
        /// The number to words converters
        /// </summary>
        private static readonly LocaliserRegistry<INumberToWordsConverter> _numberToWordsConverters = new NumberToWordsConverterRegistry();
        /// <summary>
        /// A registry of number to words converters used to localise ToWords and ToOrdinalWords methods
        /// </summary>
        /// <value>The number to words converters.</value>
        public static LocaliserRegistry<INumberToWordsConverter> NumberToWordsConverters
        {
            get { return _numberToWordsConverters; }
        }

        /// <summary>
        /// The ordinalizers
        /// </summary>
        private static readonly LocaliserRegistry<IOrdinalizer> _ordinalizers = new OrdinalizerRegistry();
        /// <summary>
        /// A registry of ordinalizers used to localise Ordinalize method
        /// </summary>
        /// <value>The ordinalizers.</value>
        public static LocaliserRegistry<IOrdinalizer> Ordinalizers
        {
            get { return _ordinalizers; }
        }

        /// <summary>
        /// The date to ordinal word converters
        /// </summary>
        private static readonly LocaliserRegistry<IDateToOrdinalWordConverter> _dateToOrdinalWordConverters = new DateToOrdinalWordsConverterRegistry();
        /// <summary>
        /// A registry of ordinalizers used to localise Ordinalize method
        /// </summary>
        /// <value>The date to ordinal words converters.</value>
        public static LocaliserRegistry<IDateToOrdinalWordConverter> DateToOrdinalWordsConverters
        {
            get { return _dateToOrdinalWordConverters; }
        }

        /// <summary>
        /// Gets the collection formatter.
        /// </summary>
        /// <value>The collection formatter.</value>
        internal static ICollectionFormatter CollectionFormatter
        {
            get
            {
                return CollectionFormatters.ResolveForUiCulture();
            }
        }

        /// <summary>
        /// The formatter to be used
        /// </summary>
        /// <param name="culture">The culture to retrieve formatter for. Null means that current thread's UI culture should be used.</param>
        /// <returns>IFormatter.</returns>
        internal static IFormatter GetFormatter(CultureInfo culture)
        {
            return Formatters.ResolveForCulture(culture);
        }

        /// <summary>
        /// The converter to be used
        /// </summary>
        /// <param name="culture">The culture to retrieve number to words converter for. Null means that current thread's UI culture should be used.</param>
        /// <returns>INumberToWordsConverter.</returns>
        internal static INumberToWordsConverter GetNumberToWordsConverter(CultureInfo culture)
        {
            return NumberToWordsConverters.ResolveForCulture(culture);
        }

        /// <summary>
        /// The ordinalizer to be used
        /// </summary>
        /// <value>The ordinalizer.</value>
        internal static IOrdinalizer Ordinalizer
        {
            get
            {
                return Ordinalizers.ResolveForUiCulture();
            }
        }

        /// <summary>
        /// The ordinalizer to be used
        /// </summary>
        /// <value>The date to ordinal words converter.</value>
        internal static IDateToOrdinalWordConverter DateToOrdinalWordsConverter
        {
            get
            {
                return DateToOrdinalWordsConverters.ResolveForUiCulture();
            }
        }

        /// <summary>
        /// The date time humanize strategy
        /// </summary>
        private static IDateTimeHumanizeStrategy _dateTimeHumanizeStrategy = new DefaultDateTimeHumanizeStrategy();
        /// <summary>
        /// The strategy to be used for DateTime.Humanize
        /// </summary>
        /// <value>The date time humanize strategy.</value>
        public static IDateTimeHumanizeStrategy DateTimeHumanizeStrategy
        {
            get { return _dateTimeHumanizeStrategy; }
            set { _dateTimeHumanizeStrategy = value; }
        }

        /// <summary>
        /// The date time offset humanize strategy
        /// </summary>
        private static IDateTimeOffsetHumanizeStrategy _dateTimeOffsetHumanizeStrategy = new DefaultDateTimeOffsetHumanizeStrategy();
        /// <summary>
        /// The strategy to be used for DateTimeOffset.Humanize
        /// </summary>
        /// <value>The date time offset humanize strategy.</value>
        public static IDateTimeOffsetHumanizeStrategy DateTimeOffsetHumanizeStrategy
        {
            get { return _dateTimeOffsetHumanizeStrategy; }
            set { _dateTimeOffsetHumanizeStrategy = value; }
        }

        /// <summary>
        /// The default enum description property locator
        /// </summary>
        private static readonly Func<PropertyInfo, bool> DefaultEnumDescriptionPropertyLocator = p => p.Name == "Description";
        /// <summary>
        /// The enum description property locator
        /// </summary>
        private static Func<PropertyInfo, bool> _enumDescriptionPropertyLocator = DefaultEnumDescriptionPropertyLocator;
        /// <summary>
        /// A predicate function for description property of attribute to use for Enum.Humanize
        /// </summary>
        /// <value>The enum description property locator.</value>
        public static Func<PropertyInfo, bool> EnumDescriptionPropertyLocator
        {
            get { return _enumDescriptionPropertyLocator; }
            set { _enumDescriptionPropertyLocator = value ?? DefaultEnumDescriptionPropertyLocator; }
        }
    }
}
