﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTLProject.Enums
{
    class Constants
    {
        /// <summary>
        /// Tarit models names
        /// </summary>
        public const string NoQTL = "No QTL";
        public const string OneQTL = "1 QTL";
        public const string DominantQTL = "Dominant 1 QTL";
        public const string TwoLinkedQTL = "2 Linked QTL";

        /// <summary>
        /// Genetic table header titles
        /// </summary>
        public const string ChrNum = "Chr Num.";
        public const string ChrLen = "Chr Len. (cM)";
        public const string MarkerPerChr = "Marker per Chr";
        public const string PopSize = "Pop Size";
        public const string MissingData = "Missing Data %";
        public const string Error = "Error %";


        /// <summary>
        ///  Trait table column names
        /// </summary>
        public const string QtlPos= "QTL pos (cM)";
        public const string QTLChr="QTL Chr";
        public const string VarQ="Var Q";
        public const string Varq="Var q";
        public const string AvgQ="Avq. Q";
        public const string Avgq="Avq. q";


        /// <summary>
        /// Table columns for input Data table
        /// </summary>
        public const string Marker = "Marker";
        public const string CoorcM = "Coor(cM)";
        public const string Chr = "Chr";
        public const string Quality = "Quality";
        public const string Map = "Map";

        /// <summary>
        /// Table names
        /// </summary>
        public const string GeneticTableRowName = "GeneticTableRow";
        public const string TraitTableRowName = "TraitTableRow";
        public const string InputDataTableRowName = "InputDataTableRow";
        /// <summary>
        /// Tool tips strings for Input Data View
        /// </summary>
        public const string LoadFile = "Loads File";
        public const string SaveFile = "Saves current Table";
        public const string CopiesRows = "Copies the selected rows";
        public const string PasteRows = "Pastes the selected rows";
        public const string InsertRows = "Inserts rows at the end of the table";
        public const string RemoveRows = "Removes rows from the end of the table";

        /// <summary>
        /// Tool tip string for Calculate QTL View
        /// </summary>
        public const string OpenGenFile = "Browse for Genotype File";
        public const string OpenPhenFile = "Browse for Phenotype File";

        /// <summary>
        /// Tool tip for  all Views
        /// </summary>
        public const string GoToNextStage = "Go to next stage";
        public const string GoToPrevStage = "Go to prevoius stage";
        
    
    }

    class ColorConstants
    {
        public static Color tableHeaderColor = Color.FromArgb(199, 243, 252);
        public static Color backgroundColor = Color.FromArgb(239, 252, 255);
        public static Color backgroundContrastColor = Color.FromArgb(255, 255, 255);
    }
}
