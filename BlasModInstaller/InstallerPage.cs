﻿using BlasModInstaller.Grouping;
using BlasModInstaller.Loading;
using BlasModInstaller.Sorting;
using BlasModInstaller.UIHolding;
using BlasModInstaller.Validation;
using System.Drawing;

namespace BlasModInstaller
{
    internal class InstallerPage
    {
        private readonly string _title;
        private readonly Bitmap _image;

        private readonly IGrouper _grouper;
        private readonly ILoader _loader;
        private readonly ISorter _sorter;
        private readonly IUIHolder _uiHolder;
        private readonly IValidator _validator;

        public InstallerPage(string title, Bitmap image, IGrouper grouper, ILoader loader, ISorter sorter, IUIHolder uiHolder, IValidator validator)
        {
            _title = title;
            _image = image;

            _grouper = grouper;
            _loader = loader;
            _sorter = sorter;
            _uiHolder = uiHolder;
            _validator = validator;
        }

        public string Title => _title;
        public Bitmap Image => _image;

        public IGrouper Grouper => _grouper;
        public ILoader Loader => _loader;
        public ISorter Sorter => _sorter;
        public IUIHolder UIHolder => _uiHolder;
        public IValidator Validator => _validator;
    }
}
