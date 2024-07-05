using System;

public class DynamicArray
{
	int size;
	int capacity;
	Object[] array;

	public DynamicArray()
	{
		this.capacity = 10;
		this.array = new Object[capacity];
	}

	public DynamicArray(int cap)
	{
		this.capacity = cap;
		this.array = new Object[capacity];
	}

	public int Capacity
	{
		get
		{
			return capacity;
		}
		set
		{
			this.capacity = value;
		}
	}

    public int Size
    {
        get
        {
            return size;
        }
        set
        {
            this.size = value;
        }
    }

    public void Add(Object data)
	{
		if (size >= capacity)
		{
			Grow();
		}

		array[size] = data;
		this.size++;
	}

	public void Insert(int index, Object data) 
	{
		if (size >= capacity)
		{
			Grow();
		}

		for (int i = size; i > index; i--)
		{
			array[i] = array[i - 1];
		}

		this.array[index] = data;
		this.size++;
	}

	public void Delete(Object data)
	{
		for(int i = 0; i < size; i++)
		{
			if (array[i] == data)
			{
				for (int j = 0; j < (size - i - 1); j++)
				{
					array[i + j] = array[i + j + 1];
				}
				array[size - 1] = null;
				size--;

				if (size <= (int) (capacity/3))
				{
					Shrink();
				}
				break;
			}
		}
	}

	public int Search(Object data)
	{
		for(int i = 0; i < size; i++)
		{
			if (array[i] == data)
			{
				return i;
			}
		}

		return -1;
	}

	public void Grow()
	{
		int newCap = (int) (capacity * 2);

		Object[] newArray = new Object[newCap];

		for(int i = 0; i < size; i++)
		{
			newArray[i] = array[i];
		}

		capacity = newCap;

		array = newArray;
	}

	public void Shrink()
	{
        int newCap = (int)(capacity / 2);

        Object[] newArray = new Object[newCap];

        for (int i = 0; i < size; i++)
        {
            newArray[i] = array[i];
        }

        capacity = newCap;

        array = newArray;
    }

	public bool isEmpty()
	{
		return size == 0;
	}

	public override String ToString()
	{
		String dataStr = "";

		for (int i = 0; i < capacity; i++)
		{
			dataStr += array[i] + ", ";
		}

		if (!string.IsNullOrWhiteSpace(dataStr))
		{
			dataStr = "[" + dataStr.Substring(0, dataStr.Length - 2) + "]";
		}
		else
		{
			dataStr = "[ ]";
		}

		return dataStr;
	}
}
