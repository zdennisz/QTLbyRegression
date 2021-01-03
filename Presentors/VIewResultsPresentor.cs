﻿using LiveCharts;
using LiveCharts.Defaults;
using QTLProject.Enums;
using QTLProject.Models;
using QTLProject.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using CartesianChart = LiveCharts.WinForms.CartesianChart;

namespace QTLProject
{
    public class VIewResultsPresentor
    {
        #region Fields
        Database db = null;
        HistogramChart histChart;
        HistogramChart PValhistChart;
        LineChartXY lineChart;
        #endregion Fields

        #region Constructor
        public VIewResultsPresentor()
        {
            //traithistogramChart = new HistogramChart(chart);
            db = DatabaseProvider.GetDatabase();
            //calcs
        }

        #endregion Constructor

        #region Public Methods
        public List<Trait> GetTraitList()
        {

            return (List<Trait>)db.SubData[0].Trait;

        }




        public void GenereateQTLEffect()
        {

        }



        public void TraitDistributionHistogram(int traitIndex, CartesianChart chart)
        {

            HistogramChart histChart = new HistogramChart(chart);


            histChart.AxisXTitle = "Trait Values";
            histChart.AxisYTitle = "Proportion of Individuals";
            histChart.RemvoeColumnSeries();

            double max, min;
            max = db.SubData[0].TraitValue[0, traitIndex];
            min = db.SubData[0].TraitValue[0, traitIndex];
            double popSize = 0.0;
            // make sure that our population is according to the size of the traits that we actually have info about them      
            foreach (DataIndividualsAndTraits ind in db.SubData)
            {
                if (ind.TraitValueOk[0, traitIndex] == true)
                {
                    popSize++;
                }
            }

            for (int i = 0; i < db.SubData.Count; i++)
            {

                if (db.SubData[i].TraitValue[0, traitIndex] > max && db.SubData[i].TraitValueOk[0, traitIndex] == true)
                {
                    max = db.SubData[i].TraitValue[0, traitIndex];
                }


            }



            double twentyPrecent = 0.0, fortyPrecent = 0.0, sixtyPrecent = 0.0, eightPrecent = 0.0, onehundredPrecent = 0.0;

            for (int i = 0; i < this.db.SubData.Count; i++)
            {
                double temp = db.SubData[i].TraitValue[0, traitIndex];
                temp = temp / max;
                if (temp >= 0.0 && temp < 0.2 && db.SubData[i].TraitValueOk[0, traitIndex] == true)
                {
                    twentyPrecent++;

                }
                else if (temp >= 0.2 && temp < 0.4 && db.SubData[i].TraitValueOk[0, traitIndex] == true)
                {
                    fortyPrecent++;

                }
                else if (temp >= 0.4 && temp < 0.6 && db.SubData[i].TraitValueOk[0, traitIndex] == true)
                {
                    sixtyPrecent++;

                }
                else if (temp >= 0.6 && temp < 0.8 && db.SubData[i].TraitValueOk[0, traitIndex] == true)
                {
                    eightPrecent++;

                }
                else if (temp >= 0.8 && temp < 1.0 && db.SubData[i].TraitValueOk[0, traitIndex] == true)
                {
                    onehundredPrecent++;

                }

            }


            //get the proportion of the indivivuals
            List<string> titles = new List<string>();
            titles.Add("0.0-" + (max * 0.2).ToString("0.00"));
            titles.Add((max * 0.2).ToString("0.00") + "-" + (max * 0.4).ToString("0.00"));
            titles.Add((max * 0.4).ToString("0.00") + "-" + (max * 0.6).ToString("0.00"));
            titles.Add((max * 0.6).ToString("0.00") + "-" + (max * 0.8).ToString("0.00"));
            titles.Add((max * 0.8).ToString("0.00") + "-" + (max).ToString("0.00"));
            List<double> values = new List<double>();
            values.Add(twentyPrecent / popSize);
            values.Add(fortyPrecent / popSize);
            values.Add(sixtyPrecent / popSize);
            values.Add(eightPrecent / popSize);
            values.Add(onehundredPrecent / popSize);

            histChart.AddColumnSeries(titles, values, ColorConstants.highliteColor);
        }

        public void MarkerQualityHistogram(CartesianChart chart)
        {

            HistogramChart histChart = new HistogramChart(chart);

            histChart.AxisXTitle = " Missing Data %";
            histChart.AxisYTitle = "Proportion of Markers %";

            // find out which markers are:
            //0-20% 
            //20-40%
            //40-60%
            //60-80% 
            //80-100%
            int twentyPercent = 0;
            int fortyPercent = 0;
            int sixtyPercent = 0;
            int eightyPercent = 0;
            int oneHundrerdPercent = 0;
            double popSize = db.SubData.Count * 1.0;
            double temp;
            double counter = 0;
            // this is our 100%
            double genotypeSize = db.SubData[0].Genotype.Length;

            //we iterate over all the population
            for (int i = 0; i < this.db.SubData.Count; i++)
            {
                counter = 0;
                //we iterate over the genotype of each person
                for (int j = 0; j < this.db.SubData[i].Genotype.Length; j++)
                {
                    if (this.db.SubData[i].GenotypeOk[0, j] == true)
                    {
                        counter++;
                    }

                }
                //we finished going over the persons genotype divide by the 100 percent and add to the relevant bucket

                temp = counter / genotypeSize;
                if (temp >= 0.0 && temp < 0.2)
                {
                    twentyPercent++;
                }
                else if (temp >= 0.2 && temp < 0.4)
                {
                    fortyPercent++;
                }
                else if (temp >= 0.4 && temp < 0.6)
                {
                    sixtyPercent++;
                }
                else if (temp >= 0.6 && temp < 0.8)
                {
                    eightyPercent++;
                }
                else if (temp >= 0.8 && temp <= 1.0)
                {
                    oneHundrerdPercent++;
                }

            }
            //we have all the data now we arrange it in the format the histogram has to accept
            List<string> titles = new List<string>();
            titles.Add("0-20%");
            titles.Add("20-40%");
            titles.Add("40-60%");
            titles.Add("60-80%");
            titles.Add("80-100%");
            List<double> values = new List<double>();
            values.Add(twentyPercent / popSize);
            values.Add(fortyPercent / popSize);
            values.Add(sixtyPercent / popSize);
            values.Add(eightyPercent / popSize);
            values.Add(oneHundrerdPercent / popSize);
            histChart.AddColumnSeries(titles, values, ColorConstants.highliteColor);

        }

        public void SegregationMarkerHistogram(CartesianChart chart)
        {

            HistogramChart histChart = new HistogramChart(chart);

            histChart.AxisXTitle = " n0/(n1+n0)";
            histChart.AxisYTitle = "Proportion of Markers %";
            int twentyPercent = 0, fortyPercent = 0, sixtyPercent = 0, eightyPercent = 0, oneHundrerdPercent = 0;
            double temp, counterN0 = 0, counterN1 = 0;
            double genotypeSize = db.SubData[0].Genotype.Length;
            //we iterate over all the population
            for (int i = 0; i < this.db.SubData[0].Genotype.Length; i++)
            {
                counterN0 = 0;
                counterN1 = 0;
                //we iterate over the genotype of each person
                for (int j = 0; j < this.db.SubData.Count; j++)
                {
                    if (this.db.SubData[j].Genotype[0, i] == 0)
                    {
                        counterN0++;
                    }
                    else if (this.db.SubData[j].Genotype[0, i] == 1)
                    {
                        counterN1++;
                    }

                }
                //we finished going over the persons genotype divide by the 100 percent and add to the relevant bucket

                temp = counterN0 / (counterN1 + counterN0);

                if (temp >= 0.0 && temp < 0.2)
                {
                    twentyPercent++;
                }
                else if (temp >= 0.2 && temp < 0.4)
                {
                    fortyPercent++;
                }
                else if (temp >= 0.4 && temp < 0.6)
                {
                    sixtyPercent++;
                }
                else if (temp >= 0.6 && temp < 0.8)
                {
                    eightyPercent++;
                }
                else if (temp >= 0.8 && temp <= 1.0)
                {
                    oneHundrerdPercent++;
                }

            }
            List<string> titles = new List<string>();
            titles.Add("0-20%");
            titles.Add("20-40%");
            titles.Add("40-60%");
            titles.Add("60-80%");
            titles.Add("80-100%");
            List<double> values = new List<double>();
            values.Add(twentyPercent / genotypeSize);
            values.Add(fortyPercent / genotypeSize);
            values.Add(sixtyPercent / genotypeSize);
            values.Add(eightyPercent / genotypeSize);
            values.Add(oneHundrerdPercent / genotypeSize);
            histChart.AddColumnSeries(titles, values, ColorConstants.highliteColor);
        }

        List<double> pLogValues = new List<double>();

        public void PValueHistogram(CartesianChart chart)
        {
            if (PValhistChart == null)
            {
                PValhistChart = new HistogramChart(chart);
            }
            PValhistChart.AxisXTitle = "P-Value";
            PValhistChart.AxisYTitle = "Proportion of Markers %";
            PValhistChart.RemvoeColumnSeries();
            int twentyPercent = 0;
            int fortyPercent = 0;
            int sixtyPercent = 0;
            int eightyPercent = 0;
            int oneHundrerdPercent = 0;
            double temp = 0.0;
            double popSize = (db.SubData[0].Genotype.Length) * (db.SubData[0].TraitValue.Length) * 1.0;


            //go over all the individuals of first marker and first trait and calculate p value  
            //get the answer and put it in the correct bin 
            for (int i = 0; i < this.db.SubData[0].Genotype.Length; i++)
            {
                //we get the wanted genotype index
                for (int j = 0; j < this.db.SubData[0].TraitValue.Length; j++)
                {
                    //we get the wanted trait index
                    List<double> no = new List<double>();
                    List<double> n1 = new List<double>();
                    for (int k = 0; k < this.db.SubData.Count; k++)
                    {
                        if (this.db.SubData[k].Genotype[0, i] == 0)
                        {
                            no.Add(this.db.SubData[k].TraitValue[0, j]);
                        }
                        else if (this.db.SubData[k].Genotype[0, i] == 1)
                        {
                            n1.Add(this.db.SubData[k].TraitValue[0, j]);
                        }
                        //iterate over all the people and gather two groups of n0 and n1
                    }
                    //calculate the pvalue for trait and genotype and put in the correct bin
                    //temp=result of p value
                    temp = StatisticCalculations.PValueTStatistic(no, n1);
                    pLogValues.Add((-1.0 * Math.Log(temp)));
                    if (temp >= 0.0 && temp < 0.2)
                    {
                        twentyPercent++;
                    }
                    else if (temp >= 0.2 && temp < 0.4)
                    {
                        fortyPercent++;
                    }
                    else if (temp >= 0.4 && temp < 0.6)
                    {
                        sixtyPercent++;
                    }
                    else if (temp >= 0.6 && temp < 0.8)
                    {
                        eightyPercent++;
                    }
                    else if (temp >= 0.8 && temp <= 1.0)
                    {
                        oneHundrerdPercent++;
                    }
                }
            }

            List<double> pValues = new List<double>();
            pValues.Add(twentyPercent / popSize);
            pValues.Add(fortyPercent / popSize);
            pValues.Add(sixtyPercent / popSize);
            pValues.Add(eightyPercent / popSize);
            pValues.Add(oneHundrerdPercent / popSize);
            List<string> pTitles = new List<string>();
            pTitles.Add("0-20%");
            pTitles.Add("20-40%");
            pTitles.Add("40-60%");
            pTitles.Add("60-80%");
            pTitles.Add("80-100%");
            PValhistChart.AddColumnSeries(pTitles, pValues, ColorConstants.highliteColor);
        }

        public void PValueLogHistogram(CartesianChart chart)
        {
            int twentyPercent = 0;
            int fortyPercent = 0;
            int sixtyPercent = 0;
            int eightyPercent = 0;
            int oneHundrerdPercent = 0;
            double popSize = (db.SubData[0].Genotype.Length) * (db.SubData[0].TraitValue.Length) * 1.0;
            if (PValhistChart == null)
            {
                PValhistChart = new HistogramChart(chart);
            }
            PValhistChart.RemvoeColumnSeries();
            PValhistChart.AxisXTitle = "-Log(P-Value)";
            PValhistChart.AxisYTitle = "-Log(Proportion of Markers %)";


            foreach (double d in pLogValues)
            {
                if (d >= 0.0 && d < 0.2)
                {
                    twentyPercent++;
                }
                else if (d >= 0.2 && d < 0.4)
                {
                    fortyPercent++;
                }
                else if (d >= 0.4 && d < 0.6)
                {
                    sixtyPercent++;
                }
                else if (d >= 0.6 && d < 0.8)
                {
                    eightyPercent++;
                }
                else if (d >= 0.8 && d <= 1.0)
                {
                    oneHundrerdPercent++;
                }
            }


            List<double> pValues = new List<double>();
            pValues.Add((twentyPercent / popSize));
            pValues.Add((fortyPercent / popSize));
            pValues.Add((sixtyPercent / popSize));
            pValues.Add((eightyPercent / popSize));
            pValues.Add((oneHundrerdPercent / popSize));

            List<string> pTitles = new List<string>();
            pTitles.Add("0-20%");
            pTitles.Add("20-40%");
            pTitles.Add("40-60%");
            pTitles.Add("60-80%");
            pTitles.Add("80-100%");
            PValhistChart.AddColumnSeries(pTitles, pValues, ColorConstants.highliteColor);
        }
        public void ChiSquaredLineChart(CartesianChart chart)
        {
            if (lineChart == null)
            {
                lineChart = new LineChartXY(chart);
            }

            lineChart.AxisXTitle = "Chi^2 statistic";
            lineChart.AxisYTitle = "Proportion of markers";
            double chiVal = 0;
            double chiValOverall = 0;
            double temp, counterN0 = 0, counterN1 = 0;
            // this is our 100%
            List<ObservablePoint> list = new List<ObservablePoint>();
            double genotypeSize = db.SubData[0].Genotype.Length;
            //we iterate over all the population
            for (int i = 0; i < this.db.SubData[0].Genotype.Length; i++)
            {
                counterN0 = 0;
                counterN1 = 0;
                chiVal = 0;
                //we iterate over the genotype of each person
                for (int j = 0; j < this.db.SubData.Count; j++)
                {
                    if (this.db.SubData[j].Genotype[0, i] == 0)
                    {
                        counterN0++;
                    }
                    else if (this.db.SubData[j].Genotype[0, i] == 1)
                    {
                        counterN1++;
                    }

                }
                //we finished going over the persons genotype divide by the 100 percent and add to the relevant bucket

                temp = counterN0 / (counterN1 + counterN0);
                chiVal = (Math.Pow(temp - 0.5, 2.0) / 0.5);
                chiValOverall += chiVal;
                //list.Add(new ObservablePoint(i*1.0,chiVal));

            }

            // lineChart.AddLineChart(list, 5.0);
        }


        public void QTLPosition(int index, List<LineChartXY> charts)
        {

            foreach(LineChartXY chartXy in charts)
            {
                chartXy.AxisXTitle = "Position on chromosome";
                chartXy.AxisYTitle = "-Log(P-Value)";
            }
            List<double> pLogValues = new List<double>();
           
            double temp;


            for (int i = 0; i < this.db.SubData[0].Genotype.Length; i++)
            {

                List<double> no = new List<double>();
                List<double> n1 = new List<double>();
                for (int k = 0; k < this.db.SubData.Count; k++)
                {
                    if (this.db.SubData[k].Genotype[0, i] == 0)
                    {
                        no.Add(this.db.SubData[k].TraitValue[0, index]);
                    }
                    else if (this.db.SubData[k].Genotype[0, i] == 1)
                    {
                        n1.Add(this.db.SubData[k].TraitValue[0, index]);
                    }
                    //calculate the pvalue for trait and genotype and put in the correct bin

                }
                temp = StatisticCalculations.PValueTStatistic(no, n1);
                pLogValues.Add((-1.0 * Math.Log(temp)));
            }
            List<List<ObservablePoint>> listOfSeries = new List<List<ObservablePoint>>();

            for (int i = 0; i < db.GenomeOrganization.Chromosome.Count; i++)
            {
                listOfSeries.Add(new List<ObservablePoint>());
            }

            for (int i = 0; i < pLogValues.Count; i++)
            {
                //we need to get the x value from the locus that we have saved
                var chrNum = this.db.SubData[0].Locus[i].Position.Chromosome.Name;

                listOfSeries[Convert.ToInt32(chrNum) - 1].Add(new ObservablePoint(this.db.SubData[0].Locus[i].Position.PositionChrGenetic, pLogValues[i]));

            }

            int counter = 0;
            int itemOfList = -1;
            foreach (List<ObservablePoint> l in listOfSeries)
            {
                if (counter % 9 == 0)
                {
                    itemOfList++;
                }

                l.Sort((x, y) => x.X.CompareTo(y.X));
                counter++;
                charts[itemOfList].AddLineChart(l, 5);
            }

        }


        #endregion Public Methods

    }
}
