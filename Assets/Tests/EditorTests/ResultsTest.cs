using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ResultsTest
{
    //These are ugly, but they work for now.
    //I'll put them into a more elegant loop
    //rather than separate functions.

    //The below tests check:
    //Does the ResultsAnalyzer.GetResultState function output the correct
    //result for each possible win result.
    [Test]
    public void PaperBeatsRock()
    {
        Assert.AreEqual(Result.Won, ResultAnalyzer.GetResultState(UseableItem.Paper,UseableItem.Rock));
    }
    [Test]
    public void RockBeatsScissors()
    {
        Assert.AreEqual(Result.Won, ResultAnalyzer.GetResultState(UseableItem.Rock,UseableItem.Scissors));
    }
    [Test]
    public void ScissorsBeatsPaper()
    {
        Assert.AreEqual(Result.Won, ResultAnalyzer.GetResultState(UseableItem.Scissors,UseableItem.Paper));
    }


    //Does the ResultsAnalyzer.GetResultState function output the correct
    //result for each possible loss result.
    [Test]
    public void RockLoses()
    {
        Assert.AreEqual(Result.Lost, ResultAnalyzer.GetResultState(UseableItem.Rock,UseableItem.Paper));
    }
    [Test]
    public void ScissorsLoses()
    {
        Assert.AreEqual(Result.Lost, ResultAnalyzer.GetResultState(UseableItem.Scissors,UseableItem.Rock));
    }
    [Test]
    public void PaperLoses()
    {
        Assert.AreEqual(Result.Lost, ResultAnalyzer.GetResultState(UseableItem.Paper,UseableItem.Scissors));
    }


    //Does the ResultsAnalyzer.GetResultState function output the correct
    //result for each possible draw result.
    [Test]
    public void RockDraws()
    {
        Assert.AreEqual(Result.Draw, ResultAnalyzer.GetResultState(UseableItem.Rock,UseableItem.Rock));
    }
    [Test]
    public void ScissorsDraws()
    {
        Assert.AreEqual(Result.Draw, ResultAnalyzer.GetResultState(UseableItem.Scissors,UseableItem.Scissors));
    }
    [Test]
    public void PaperDraws()
    {
        Assert.AreEqual(Result.Draw, ResultAnalyzer.GetResultState(UseableItem.Paper,UseableItem.Paper));
    }
}
