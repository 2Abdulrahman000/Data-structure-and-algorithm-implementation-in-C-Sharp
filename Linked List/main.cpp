#include<iostream>
#include<malloc.h>
#define null 0
using namespace std;

struct node//information of containt of node
{
	int value;
	node *next;
};
typedef node *ptr;
ptr new_node()//function of create node
{
	ptr p=(ptr)malloc(sizeof(node));
	return p;
}
void add_first(ptr &li,int n)//function of add node from the first
{
	ptr p=new_node();
	p->value=n;
	p->next=li;
	li=p;
}
void add_node(ptr &li,int n)//function of add node between two node
{
	ptr p=new_node();
	p->value=n;
	p->next=li->next;
	li->next=p;
}
void add_end(ptr &li,int n)//function of add node from the end
{
	ptr p=new_node();
	p->value=n;
	p->next=null;
    li->next=p;

}
void del_first(ptr&li)//function of delete node from the first
{
	ptr p=li;
	li=p->next;
	free(p);
}
void del_node(ptr&li)//function of delete node between two nodes
{
	ptr p=li->next;//n2
	li->next=p->next;
	free(p);
}
void del_end(ptr&li)//function of delete node from the end
{
	ptr p=li->next;
	li->next=null;
	free(p);
}
void show(ptr li)//function of swow the elements
{
	ptr t =li;
	while(t!=null)
	{
		cout<<t->value<<"==>";
		t=t->next;
	}
}
int main()
{
	ptr n1=new_node();//first node
	ptr n2=new_node();//secound node
	ptr n3=new_node();//third node
	ptr list =n1;//pointer on the first node
	n1->value=1;
	n1->next=n2;
	n2->value=2;
	n2->next=n3;
	n3->value=3;
	n3->next=null;
	//add_node(n2,9);
	//add_end(n2,12);
	del_end(n2);
	show(list);
	system("pause");
	return 0;
}
