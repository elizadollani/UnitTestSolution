using Microsoft.VisualStudio.TestTools.UnitTesting;
using OperationLibrary;
namespace OperationTest
{
	[TestClass]
	public class GestioneTest
	{
		[TestMethod]
		public void SommaTestPositivi()
		{
			int a = 3;
			int b = 4;
			int risultato_aspettato = 7;
			int risultato_effettivo = Gestione.Somma(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);

		}
		[TestMethod]
		public void SommaTestNegativi()
		{
			int a = -3;
			int b = -2;
			int risultato_aspettato = -5;
			int risultato_effettivo = Gestione.Somma(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void SommaTestNull()
		{
			int a = 0;
			int b = 0;
			int risultato_aspettato = 0;
			int risultato_effettivo = Gestione.Somma(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void SommaTestNulloNeg()
		{
			int a = 0;
			int b = -4;
			int risultato_aspettato = -4;
			int risultato_effettivo = Gestione.Somma(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void SottrazioneTestPositivi()
		{
			int a = 3;
			int b = 4;
			int risultato_aspettato = -1;
			int risultato_effettivo = Gestione.Sottrazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);

		}
		[TestMethod]
		public void SottrazioneTestNegativi()
		{
			int a = -3;
			int b = -2;
			int risultato_aspettato = -1;
			int risultato_effettivo = Gestione.Sottrazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void SottrazioneTestNull()
		{
			int a = 0;
			int b = 0;
			int risultato_aspettato = 0;
			int risultato_effettivo = Gestione.Sottrazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void SottrazioneTestNulloNeg()
		{
			int a = 0;
			int b = -4;
			int risultato_aspettato = 4;
			int risultato_effettivo = Gestione.Sottrazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void MoltiplicazioneTestPositivi()
		{
			int a = 3;
			int b = 4;
			int risultato_aspettato = 12;
			int risultato_effettivo = Gestione.Moltiplicazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);

		}
		[TestMethod]
		public void MoltiplicazioneTestNegativi()
		{
			int a = -3;
			int b = -2;
			int risultato_aspettato = 6;
			int risultato_effettivo = Gestione.Moltiplicazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void MoltiplicazioneTestNull()
		{
			int a = 0;
			int b = 0;
			int risultato_aspettato = 0;
			int risultato_effettivo = Gestione.Moltiplicazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void MoltiplicazioneTestNulloNeg()
		{
			int a = 6;
			int b = 0;
			int risultato_aspettato = 0;
			int risultato_effettivo = Gestione.Moltiplicazione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void DivisioneTestPositivi()
		{
			double a = 2;
			double b = 0;
			double risultato_aspettato = double.NaN;
			double risultato_effettivo = Gestione.Divisione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);

		}
		[TestMethod]
		public void DivisioneTestNegativi()
		{
			double a = -3;
			double b = 0;
			double risultato_aspettato = double.NaN;
			double risultato_effettivo = Gestione.Divisione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void DivisioneTestNull()
		{
			double a = 4;
			double b = 2;
			double risultato_aspettato = 2;
			double risultato_effettivo = Gestione.Divisione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
		[TestMethod]
		public void divisioneTestNulloNeg()
		{
			double a = 2;
			double b = 0;
			double risultato_aspettato = double.NaN ;
			double risultato_effettivo = Gestione.Divisione(a, b);
			Assert.AreEqual(risultato_aspettato, risultato_effettivo);
		}
	}
}
