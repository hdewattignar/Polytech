from django.db import models
from django.utils import timezone

class Post(models.Model):
	author = models.ForeignKey('auth.User')
	title = models.CharField(max_length=200)
	image = models.CharField(max_length=200)
	NZ = 'NewZealand'
	WR = 'World'
	TN = 'Technology'
	SP = 'Sport'	
	CATEGORY_CHOICES = (
		(NZ, 'New Zealand'),
		(WR,'World'),
		(TN,'Technology'),
		(SP,'Sport'),
	)
	category = models.CharField(
		max_length=20,
		choices = CATEGORY_CHOICES,
		default = NZ)
	
	text = models.TextField()
	created_date = models.DateTimeField(default=timezone.now)
	published_date = models.DateTimeField(blank=True, null=True)
	
	def publish(self):
		self.published_date = timezone.now() 
		self.save()
	def __str__(self):
		return self.title