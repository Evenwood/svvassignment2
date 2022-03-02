using TicTacToeApp.Logic;
using NUnit.Framework;
using System.Text;

namespace TicTacToeApp.Testing
{
    public class ATicTacToeBoard
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void ShouldHaveAnEmptyBoardWhenConstructed()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            StringBuilder expected = new StringBuilder();
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   ");
            Assert.That(sut.ToString(), Is.EqualTo(expected.ToString()));
        }

        [Test]
        public void ShouldInsertXIntoAnEmptySpace()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            bool result = sut.InsertX(0, 0);
            StringBuilder expected = new StringBuilder();
            expected.Append(" X |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   ");
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(sut.ToString(), Is.EqualTo(expected.ToString()));
            });
        }

        [Test]
        public void ShouldNotInsertXIntoAnInvalidIndex()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            bool result = sut.InsertX(3, 3);
            StringBuilder expected = new StringBuilder();
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   ");
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.False);
                Assert.That(sut.ToString(), Is.EqualTo(expected.ToString()));
            });
        }

        [Test]
        public void ShouldInsertOIntoAnEmptySpace()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            bool result = sut.InsertO(0, 0);
            StringBuilder expected = new StringBuilder();
            expected.Append(" O |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   ");
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.True);
                Assert.That(sut.ToString(), Is.EqualTo(expected.ToString()));
            });
        }

        [Test]
        public void ShouldNotInsertOIntoAFilledSpace()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 0);
            bool result = sut.InsertO(0, 0);
            StringBuilder expected = new StringBuilder();
            expected.Append(" X |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   " + Environment.NewLine);
            expected.Append("---+---+---" + Environment.NewLine);
            expected.Append("   |   |   ");
            Assert.Multiple(() =>
            {
                Assert.That(result, Is.False);
                Assert.That(sut.ToString(), Is.EqualTo(expected.ToString()));
            });
        }

        [Test]
        public void ShouldReportThatXWinsOnTopRow()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 0);
            sut.InsertX(0, 1);
            sut.InsertX(0, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatOWinsOnTopRow()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(0, 0);
            sut.InsertO(0, 1);
            sut.InsertO(0, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatXWinsOnMiddleRow()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(1, 0);
            sut.InsertX(1, 1);
            sut.InsertX(1, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatXWinsOnBottomRow()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(2, 0);
            sut.InsertX(2, 1);
            sut.InsertX(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatXWinsOnLeftColumn()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 0);
            sut.InsertX(1, 0);
            sut.InsertX(2, 0);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatXWinsOnMiddleColumn()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 1);
            sut.InsertX(1, 1);
            sut.InsertX(2, 1);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatXWinsOnRightColumn()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 2);
            sut.InsertX(1, 2);
            sut.InsertX(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatXWinsOnDownDiagonal()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 0);
            sut.InsertX(1, 1);
            sut.InsertX(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatXWinsOnUpDiagonal()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 2);
            sut.InsertX(1, 2);
            sut.InsertX(2, 0);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('X'));
        }

        [Test]
        public void ShouldReportThatOWinsOnMiddleRow()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(1, 0);
            sut.InsertO(1, 1);
            sut.InsertO(1, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatOWinsOnBottomRow()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(2, 0);
            sut.InsertO(2, 1);
            sut.InsertO(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatOWinsOnLeftColumn()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(0, 0);
            sut.InsertO(1, 0);
            sut.InsertO(2, 0);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatOWinsOnMiddleColumn()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(0, 1);
            sut.InsertO(1, 1);
            sut.InsertO(2, 1);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatOWinsOnRightColumn()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(0, 2);
            sut.InsertO(1, 2);
            sut.InsertO(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatOWinsOnDownDiagonal()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(0, 0);
            sut.InsertO(1, 1);
            sut.InsertO(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportThatOWinsOnUpDiagonal()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertO(0, 2);
            sut.InsertO(1, 2);
            sut.InsertO(2, 0);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('O'));
        }

        [Test]
        public void ShouldReportADraw()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            sut.InsertX(0, 0);
            sut.InsertO(0, 1);
            sut.InsertX(0, 2);
            sut.InsertX(1, 0);
            sut.InsertO(1, 1);
            sut.InsertX(1, 2);
            sut.InsertO(2, 0);
            sut.InsertX(2, 1);
            sut.InsertO(2, 2);
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('D'));

        }

        [Test]
        public void ShouldReportNoResult()
        {
            TicTacToeBoard sut = new TicTacToeBoard();
            char result = sut.ReportResult();
            Assert.That(result, Is.EqualTo('N'));
        }
    }
}