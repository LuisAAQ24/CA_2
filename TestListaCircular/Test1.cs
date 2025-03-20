using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class ListasCircularesTests
{
    // Pruebas para  ListaSimpleCircular
    [TestMethod]
    public void ElementoAlInicio_Circular()
    {
        
        CircularLinkedList lista = new CircularLinkedList();

        
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Inicio(20);

        
        Assert.AreEqual("20, 10", lista.ToString()); // Se espera que 20 sea el primero
    }

    [TestMethod]
    public void ElementoAlFinal_Circular()
    {
        
        CircularLinkedList lista = new CircularLinkedList();

        
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);

        
        Assert.AreEqual("10, 20", lista.ToString()); // Se espera que 10 sea el primero y 20 el segundo
    }

    [TestMethod]
    public void IndiceEspecifico_Circular()
    {
        
        CircularLinkedList lista = new CircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);

        
        lista.InsertAt(15, 1); // Insertar 15 en el índice 1

        
        Assert.AreEqual("10, 15, 20", lista.ToString()); // El orden esperado es 10, 15, 20
    }

    [TestMethod]
    public void EliminarPrimerElemento_Circular()
    {
        
        CircularLinkedList lista = new CircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        lista.Eliminar_al_Inicio();

        
        Assert.AreEqual("20", lista.ToString()); // Se espera que solo quede 20
    }

    [TestMethod]
    public void EliminarUltimoElemento_Circular()
    {

        CircularLinkedList lista = new CircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        lista.Eliminar_al_Final();


        Assert.AreEqual("10", lista.ToString()); // Se espera que solo quede 10
    }

    [TestMethod]
    public void ElementoEnIndiceEspecifico_Circular()
    {

        CircularLinkedList lista = new CircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);
        lista.Insertar_al_Final(30);


        lista.DeleteAt(1); // Eliminar el elemento en el índice 1 (20)


        Assert.AreEqual("10, 30", lista.ToString()); // Se espera que 20 haya sido eliminado
    }

    [TestMethod]
    public void TamañoCorrectoDeLaLista_Circular()
    {

        CircularLinkedList lista = new CircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        int size = lista.Size();


        Assert.AreEqual(2, size); // Se espera que el tamaño sea 2
    }

    // Pruebas para ListaDobleCircular 
    [TestMethod]
    public void ElementoAlInicio_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();


        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Inicio(20);


        Assert.AreEqual("20, 10", lista.ToString()); // Se espera que 20 sea el primero
    }

    [TestMethod]
    public void ElementoAlFinal_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();


        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        Assert.AreEqual("10, 20", lista.ToString()); // Se espera que 10 sea el primero y 20 el segundo
    }

    [TestMethod]
    public void IndiceEspecifico_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        lista.InsertAt(15, 1); // Insertar 15 en el índice 1


        Assert.AreEqual("10, 15, 20", lista.ToString()); // El orden esperado es 10, 15, 20
    }

    [TestMethod]
    public void EliminarPrimerElemento_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        lista.Eliminar_al_Inicio();


        Assert.AreEqual("20", lista.ToString()); // Se espera que solo quede 20
    }

    [TestMethod]
    public void EliminarUltimoElemento_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        lista.Eliminar_al_Final();


        Assert.AreEqual("10", lista.ToString()); // Se espera que solo quede 10
    }

    [TestMethod]
    public void ElementoEnIndiceEspecifico_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);
        lista.Insertar_al_Final(30);


        lista.DeleteAt(1); // Eliminar el elemento en el índice 1 (20)


        Assert.AreEqual("10, 30", lista.ToString()); // Se espera que 20 haya sido eliminado
    }

    [TestMethod]
    public void TamañoCorrectoDeLaLista_DobleCircular()
    {

        DoublyCircularLinkedList lista = new DoublyCircularLinkedList();
        lista.Insertar_al_Inicio(10);
        lista.Insertar_al_Final(20);


        int size = lista.Size();


        Assert.AreEqual(2, size); // Se espera que el tamaño sea 2
    }
}

