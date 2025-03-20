using System;
using System.Text;

public class DoublyCircularLinkedList
{
    private class Node
    {
        public int Data;
        public Node Next;
        public Node Prev;
        public Node(int data)
        {
            Data = data;
            Next = null;
            Prev = null;
        }
    }

    private Node head;
    private int size;

    public DoublyCircularLinkedList()
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
            head.Prev = head;
        }
        else
        {
            Node tail = head.Prev;
            newNode.Next = head;
            newNode.Prev = tail;
            tail.Next = newNode;
            head.Prev = newNode;
            head = newNode;
        }
        size++;
    }

    public void Insertar_al_Final(int data)
    {
        if (head == null)
        {
            Insertar_al_Inicio(data);
            return;
        }
        Node newNode = new Node(data);
        Node tail = head.Prev;
        newNode.Next = head;
        newNode.Prev = tail;
        tail.Next = newNode;
        head.Prev = newNode;
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
        if (index == size)
        {
            Insertar_al_Final(data);
            return;
        }

        Node newNode = new Node(data);
        Node temp = head;
        for (int i = 0; i < index - 1; i++)
            temp = temp.Next;
        newNode.Next = temp.Next;
        newNode.Prev = temp;
        temp.Next.Prev = newNode;
        temp.Next = newNode;
        size++;
    }

    public void Eliminar_al_Inicio()
    {
        if (head == null) return;
        if (head.Next == head)
        {
            head = null;
        }
        else
        {
            Node tail = head.Prev;
            head = head.Next;
            head.Prev = tail;
            tail.Next = head;
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
            Node tail = head.Prev;
            tail.Prev.Next = head;
            head.Prev = tail.Prev;
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
        if (index == size - 1)
        {
            Eliminar_al_Final();
            return;
        }

        Node temp = head;
        for (int i = 0; i < index; i++)
            temp = temp.Next;
        temp.Prev.Next = temp.Next;
        temp.Next.Prev = temp.Prev;
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
