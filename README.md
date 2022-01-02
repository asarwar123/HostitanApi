# HostitanApi
customers:
customer_id
first_name
last_name
email
phone
city
status


orders:
order_id
customer_id
order_status
order_paid_date


subscription
subs_id
order_id
customer_id
subs_status
subs_type: monthly/yearly
next_invoice_date

invoices:
invoice_id
subs_id
invoice_date
invoice_last_date
invoice_status

---------------------------------------------
-------------  webapi design

get:[customers]
/customers
/customers/id
/customers/id/subscriptions
/customers/id/subscriptions/id
/customers/id/invoices
/customers/id/invoices/id

------------ orders
/customers/id/orders
/customers/id/orders/id

/orders --all orders
/orders/id -- single order
------------------------------
/invoices

put: [customers]
create customer
update customer status
create order against a customer
update order_status & order_paid_date
create new subscription against an order
update a subscription's subs_type,subs_status & next_invoice_date
create new invoice
update invoice status


sorting & filetring of customers/invoices/subscriptions
