using System;
using System.Text;

public class CircularLinkedList
{
    private class Node
    {
        public int Data;
        public Node Next;
        public Node(int data)
        {
            Data = data;
            Next = null;
        }
    }

    private Node head;
    private int size;

    public CircularLinkedList()
    {
        head = null;
        size = 0;
    }

    public void Insertar_al_Inicio(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;
            temp.Next = newNode;
            newNode.Next = head;
            head = newNode;
        }
        size++;
    }

    public void Insertar_al_Final(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            head.Next = head;
        }
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;
            temp.Next = newNode;
            newNode.Next = head;
        }
        size++;
    }

    public void InsertAt(int data, int index)
    {
        if (index < 0 || index > size) throw new ArgumentOutOfRangeException();
        if (index == 0)
        {
            Insertar_al_Inicio(data);
            return;
        }
        Node newNode = new Node(data);
        Node temp = head;
        for (int i = 0; i < index - 1; i++)
            temp = temp.Next;
        newNode.Next = temp.Next;
        temp.Next = newNode;
        size++;
    }

    public void Eliminar_al_Inicio()
    {
        if (head == null) return;
        if (head.Next == head)
            head = null;
        else
        {
            Node temp = head;
            while (temp.Next != head)
                temp = temp.Next;
            temp.Next = head.Next;
            head = head.Next;
        }
        size--;
    }

    public void Eliminar_al_Final()
    {
        if (head == null) return;
        if (head.Next == head)
        {
            head = null;
        }
        else
        {
            Node temp = head;
            while (temp.Next.Next != head)
                temp = temp.Next;
            temp.Next = head;
        }
        size--;
    }

    public void DeleteAt(int index)
    {
        if (index < 0 || index >= size) throw new ArgumentOutOfRangeException();
        if (index == 0)
        {
            Eliminar_al_Inicio();
            return;
        }
        Node temp = head;
        for (int i = 0; i < index - 1; i++)
            temp = temp.Next;
        temp.Next = temp.Next.Next;
        size--;
    }

    public int Size() => size;

    public override string ToString()
    {
        if (head == null) return "";
        StringBuilder sb = new StringBuilder();
        Node temp = head;
        do
        {
            sb.Append(temp.Data + ", ");
            temp = temp.Next;
        } while (temp != head);
        return sb.ToString().TrimEnd(',', ' ');
    }
}
